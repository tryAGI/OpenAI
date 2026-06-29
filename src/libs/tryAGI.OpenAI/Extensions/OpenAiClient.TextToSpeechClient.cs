#nullable enable
#pragma warning disable MEAI001

using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI;

public sealed partial class OpenAiClient : Meai.ITextToSpeechClient
{
    private const string DefaultTextToSpeechModel = "gpt-4o-mini-tts";
    private const string DefaultTextToSpeechVoice = "coral";
    private Meai.TextToSpeechClientMetadata? _textToSpeechMetadata;

    object? Meai.ITextToSpeechClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return serviceKey is not null ? null :
            serviceType == typeof(Meai.TextToSpeechClientMetadata) ? (_textToSpeechMetadata ??= new("openai", new Uri(DefaultBaseUrl), DefaultTextToSpeechModel)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<Meai.TextToSpeechResponse> Meai.ITextToSpeechClient.GetAudioAsync(
        string text,
        Meai.TextToSpeechOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var request = CreateSpeechRequest(text, options, stream: false);
        var resolved = ResolveTextToSpeechOptions(request);
        using var httpRequest = CreateSpeechHttpRequest(request);
        using var response = await HttpClient.SendAsync(
            httpRequest,
            HttpCompletionOption.ResponseContentRead,
            cancellationToken).ConfigureAwait(false);

        ProcessResponse(HttpClient, response);
        await ThrowIfNotSuccessAsync(response, cancellationToken).ConfigureAwait(false);

        var audio = await response.Content.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false);
        var responseId = TryGetHeader(response, "x-request-id") ?? TryGetHeader(response, "request-id");

        return new Meai.TextToSpeechResponse([
            new Meai.DataContent(audio, resolved.MediaType),
        ])
        {
            ResponseId = responseId,
            ModelId = resolved.ModelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(request, resolved, responseId),
        };
    }

    async IAsyncEnumerable<Meai.TextToSpeechResponseUpdate> Meai.ITextToSpeechClient.GetStreamingAudioAsync(
        string text,
        Meai.TextToSpeechOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var request = CreateSpeechRequest(text, options, stream: true);
        var resolved = ResolveTextToSpeechOptions(request);
        var localResponseId = Guid.NewGuid().ToString("N");

        yield return new Meai.TextToSpeechResponseUpdate
        {
            Kind = Meai.TextToSpeechResponseUpdateKind.SessionOpen,
            ResponseId = localResponseId,
            ModelId = resolved.ModelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(request, resolved),
        };

        using var httpRequest = CreateSpeechHttpRequest(request);
        using var response = await HttpClient.SendAsync(
            httpRequest,
            HttpCompletionOption.ResponseHeadersRead,
            cancellationToken).ConfigureAwait(false);

        ProcessResponse(HttpClient, response);
        await ThrowIfNotSuccessAsync(response, cancellationToken).ConfigureAwait(false);

        var responseId = TryGetHeader(response, "x-request-id") ?? TryGetHeader(response, "request-id") ?? localResponseId;
        using var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
        var buffer = new byte[16 * 1024];
        while (true)
        {
            var bytesRead = await stream.ReadAsync(buffer, cancellationToken).ConfigureAwait(false);
            if (bytesRead <= 0)
            {
                break;
            }

            yield return new Meai.TextToSpeechResponseUpdate([
                new Meai.DataContent(buffer.AsSpan(0, bytesRead).ToArray(), resolved.MediaType),
            ])
            {
                Kind = Meai.TextToSpeechResponseUpdateKind.AudioUpdating,
                ResponseId = responseId,
                ModelId = resolved.ModelId,
                AdditionalProperties = CreateResponseProperties(request, resolved, responseId),
            };
        }

        yield return new Meai.TextToSpeechResponseUpdate
        {
            Kind = Meai.TextToSpeechResponseUpdateKind.AudioUpdated,
            ResponseId = responseId,
            ModelId = resolved.ModelId,
            AdditionalProperties = CreateResponseProperties(request, resolved, responseId),
        };

        yield return new Meai.TextToSpeechResponseUpdate
        {
            Kind = Meai.TextToSpeechResponseUpdateKind.SessionClose,
            ResponseId = responseId,
            ModelId = resolved.ModelId,
        };
    }

    private CreateSpeechRequest CreateSpeechRequest(
        string text,
        Meai.TextToSpeechOptions? options,
        bool stream)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as CreateSpeechRequest
            ?? new CreateSpeechRequest
            {
                Model = CreateSpeechModel(options?.ModelId),
                Input = text,
                Voice = CreateSpeechVoice(options),
            };

        if (IsMissingModel(request.Model))
        {
            request.Model = CreateSpeechModel(options?.ModelId);
        }

        if (string.IsNullOrWhiteSpace(request.Input))
        {
            request.Input = text;
        }

        if (IsMissingVoice(request.Voice))
        {
            request.Voice = CreateSpeechVoice(options);
        }

        request.ResponseFormat ??= ResolveResponseFormat(options?.AudioFormat);
        request.Speed ??= options?.Speed;
        request.Instructions ??= options.GetString(OpenAiTextToSpeechPropertyNames.Instructions);
        if (stream)
        {
            request.StreamFormat ??= CreateSpeechRequestStreamFormat.Audio;
        }

        if (options?.Language is { Length: > 0 } language)
        {
            request.AdditionalProperties.TryAdd("language", language);
        }

        return request;
    }

    private HttpRequestMessage CreateSpeechHttpRequest(CreateSpeechRequest request)
    {
        PrepareArguments(HttpClient);

        var httpRequest = new HttpRequestMessage(HttpMethod.Post, CreateEndpointUri("audio/speech"))
        {
            Content = new StringContent(
                request.ToJson(JsonSerializerContext),
                Encoding.UTF8,
                "application/json"),
        };

        httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", ResolveBearerApiKey());
        AutoSDKRequestOptionsSupport.ApplyHeaders(
            request: httpRequest,
            clientHeaders: Options.Headers,
            requestHeaders: null);
        PrepareRequest(HttpClient, httpRequest);

        return httpRequest;
    }

    private Uri CreateEndpointUri(string relativePath)
    {
        var baseUri = HttpClient.BaseAddress ?? new Uri(DefaultBaseUrl);
        var baseText = baseUri.AbsoluteUri.TrimEnd('/') + "/";
        return new Uri(new Uri(baseText), relativePath);
    }

    private string ResolveBearerApiKey()
    {
        for (var i = 0; i < Authorizations.Count; i++)
        {
            var authorization = Authorizations[i];
            if (authorization is { Type: "Http", Name: "Bearer", Value.Length: > 0 })
            {
                return authorization.Value;
            }
        }

        throw new InvalidOperationException("No API key found in OpenAiClient.Authorizations. Ensure the client was created with an API key.");
    }

    private static AnyOf<string, CreateSpeechRequestModel?> CreateSpeechModel(string? modelId)
    {
        var resolvedModelId = modelId is { Length: > 0 } ? modelId : DefaultTextToSpeechModel;
        var knownModel = CreateSpeechRequestModelExtensions.ToEnum(resolvedModelId);
        return knownModel is { } value
            ? AnyOf<string, CreateSpeechRequestModel?>.FromValue2(value)
            : AnyOf<string, CreateSpeechRequestModel?>.FromValue1(resolvedModelId);
    }

    private static bool IsMissingModel(AnyOf<string, CreateSpeechRequestModel?> model)
    {
        return !model.Validate()
            || (model.Value1 is not null && string.IsNullOrWhiteSpace(model.Value1));
    }

    private static VoiceIdsOrCustomVoice CreateSpeechVoice(Meai.TextToSpeechOptions? options)
    {
        var voiceId = options?.VoiceId is { Length: > 0 } value ? value : DefaultTextToSpeechVoice;
        var customVoice = options.GetBool(OpenAiTextToSpeechPropertyNames.CustomVoice)
            ?? voiceId.StartsWith("voice_", StringComparison.OrdinalIgnoreCase);
        if (customVoice)
        {
            return VoiceIdsOrCustomVoice.FromVoiceIdsOrCustomVoiceVariant2(new VoiceIdsOrCustomVoiceVariant2
            {
                Id = voiceId,
            });
        }

        var knownVoice = VoiceIdsSharedEnumExtensions.ToEnum(voiceId);
        return knownVoice is { } known
            ? VoiceIdsOrCustomVoice.FromShared(VoiceIdsShared.FromEnum(known))
            : VoiceIdsOrCustomVoice.FromShared(VoiceIdsShared.FromVoiceIdsSharedVariant1(voiceId));
    }

    private static bool IsMissingVoice(VoiceIdsOrCustomVoice voice)
    {
        return !voice.Validate()
            || string.IsNullOrWhiteSpace(voice.ToString());
    }

    private static CreateSpeechRequestResponseFormat ResolveResponseFormat(string? format)
    {
        if (format is not { Length: > 0 })
        {
            return CreateSpeechRequestResponseFormat.Mp3;
        }

        if (string.Equals(format, "audio/mpeg", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/mp3", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "mp3", StringComparison.OrdinalIgnoreCase))
        {
            return CreateSpeechRequestResponseFormat.Mp3;
        }

        if (string.Equals(format, "audio/ogg", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/opus", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "opus", StringComparison.OrdinalIgnoreCase))
        {
            return CreateSpeechRequestResponseFormat.Opus;
        }

        if (string.Equals(format, "audio/aac", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "aac", StringComparison.OrdinalIgnoreCase))
        {
            return CreateSpeechRequestResponseFormat.Aac;
        }

        if (string.Equals(format, "audio/flac", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "flac", StringComparison.OrdinalIgnoreCase))
        {
            return CreateSpeechRequestResponseFormat.Flac;
        }

        if (string.Equals(format, "audio/wav", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/wave", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "wav", StringComparison.OrdinalIgnoreCase))
        {
            return CreateSpeechRequestResponseFormat.Wav;
        }

        if (string.Equals(format, "audio/pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "pcm_s16le", StringComparison.OrdinalIgnoreCase))
        {
            return CreateSpeechRequestResponseFormat.Pcm;
        }

        throw new NotSupportedException($"Unsupported OpenAI TTS audio format '{format}'. Use 'mp3', 'opus', 'aac', 'flac', 'wav', or 'pcm'.");
    }

    private static ResolvedOpenAiTextToSpeechOptions ResolveTextToSpeechOptions(CreateSpeechRequest request)
    {
        var modelId =
            request.Model.Value1 is { Length: > 0 } stringModel ? stringModel :
            request.Model.Value2 is { } enumModel ? enumModel.ToValueString() :
            DefaultTextToSpeechModel;
        var responseFormat = request.ResponseFormat ?? CreateSpeechRequestResponseFormat.Mp3;

        return new ResolvedOpenAiTextToSpeechOptions(
            modelId,
            responseFormat,
            ResolveMediaType(responseFormat));
    }

    private static string ResolveMediaType(CreateSpeechRequestResponseFormat format)
    {
        return format switch
        {
            CreateSpeechRequestResponseFormat.Aac => "audio/aac",
            CreateSpeechRequestResponseFormat.Flac => "audio/flac",
            CreateSpeechRequestResponseFormat.Mp3 => "audio/mpeg",
            CreateSpeechRequestResponseFormat.Opus => "audio/ogg;codecs=opus",
            CreateSpeechRequestResponseFormat.Pcm => "audio/pcm;codec=s16le",
            CreateSpeechRequestResponseFormat.Wav => "audio/wav",
            _ => "application/octet-stream",
        };
    }

    private static Meai.AdditionalPropertiesDictionary CreateResponseProperties(
        CreateSpeechRequest request,
        ResolvedOpenAiTextToSpeechOptions resolved,
        string? responseId = null)
    {
        Meai.AdditionalPropertiesDictionary properties = new()
        {
            ["model_id"] = resolved.ModelId,
            ["voice"] = request.Voice.ToString() ?? DefaultTextToSpeechVoice,
            ["response_format"] = resolved.ResponseFormat.ToValueString(),
            ["media_type"] = resolved.MediaType,
        };

        if (request.Instructions is { Length: > 0 })
        {
            properties["instructions"] = request.Instructions;
        }

        if (request.Speed is { } speed)
        {
            properties["speed"] = speed;
        }

        if (responseId is { Length: > 0 })
        {
            properties["request_id"] = responseId;
        }

        return properties;
    }

    private static async Task ThrowIfNotSuccessAsync(
        HttpResponseMessage response,
        CancellationToken cancellationToken)
    {
        if (response.IsSuccessStatusCode)
        {
            return;
        }

        string? responseBody = null;
        Exception? readException = null;
        try
        {
            responseBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        }
        catch (HttpRequestException ex)
        {
            readException = ex;
        }
        catch (IOException ex)
        {
            readException = ex;
        }

        throw ApiException.Create(
            response.StatusCode,
            responseBody ?? response.ReasonPhrase ?? string.Empty,
            readException,
            responseBody,
            AutoSDKHttpResponse.CreateHeaders(response));
    }

    private static string? TryGetHeader(HttpResponseMessage response, string name)
    {
        return response.Headers.TryGetValues(name, out var values)
            ? values.FirstOrDefault()
            : response.Content.Headers.TryGetValues(name, out values)
                ? values.FirstOrDefault()
                : null;
    }

    private sealed record ResolvedOpenAiTextToSpeechOptions(
        string ModelId,
        CreateSpeechRequestResponseFormat ResponseFormat,
        string MediaType);
}

internal static class OpenAiTextToSpeechOptionsExtensions
{
    public static bool? GetBool(this Meai.TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            bool boolValue => boolValue,
            string text when bool.TryParse(text, out var parsed) => parsed,
            _ => null,
        };
    }

    public static string? GetString(this Meai.TextToSpeechOptions? options, string key)
    {
        return options?.AdditionalProperties is { } properties
            && properties.TryGetValue(key, out var value)
            && value is string text
            && text.Length > 0
                ? text
                : null;
    }
}
