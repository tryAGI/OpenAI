#nullable enable

using System.CommandLine;
using System.CommandLine.Parsing;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tryAGI.OpenAI.Cli.GeneratedApi;

internal static class CliRuntime
{
    private const string UserSecretsId = "tryAGI.OpenAI.CLI";
    private const string UserSecretApiKeyName = "OPENAI_API_KEY";
    private static readonly string[] ApiKeyEnvironmentVariables = [@"OPENAI_API_KEY"];

    public static async Task<global::tryAGI.OpenAI.OpenAiClient> CreateClientAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        var apiKey = await TryResolveApiKeyAsync(parseResult, cancellationToken).ConfigureAwait(false);
        var authorizations = string.IsNullOrWhiteSpace(apiKey)
            ? new global::System.Collections.Generic.List<global::tryAGI.OpenAI.EndPointAuthorization>()
            : new global::System.Collections.Generic.List<global::tryAGI.OpenAI.EndPointAuthorization>
            {
        new global::tryAGI.OpenAI.EndPointAuthorization
        {
            Type = "Http",
            SchemeId = "ApiKeyAuth",
            Location = "Header",
            Name = "Bearer",
            Value = apiKey,
        },
            };
        var baseUri = ResolveBaseUri(parseResult);

        return new global::tryAGI.OpenAI.OpenAiClient(
            httpClient: null,
            baseUri: baseUri,
            authorizations: authorizations,
            disposeHttpClient: true);
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Design",
        "CA1031:Do not catch general exception types",
        Justification = "Generated CLI commands map unexpected failures to a stable exit code.")]
    public static async Task<int> RunAsync(Func<Task> action, CancellationToken cancellationToken = default)
    {
        try
        {
            await action().ConfigureAwait(false);
            return 0;
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
            await Console.Error.WriteLineAsync("Canceled.").ConfigureAwait(false);
            return 130;
        }
        catch (global::tryAGI.OpenAI.ApiException exception)
        {
            await WriteApiExceptionAsync(exception).ConfigureAwait(false);
            return 2;
        }
        catch (CliException exception)
        {
            await Console.Error.WriteLineAsync(exception.Message).ConfigureAwait(false);
            return 1;
        }
        catch (Exception exception)
        {
            await Console.Error.WriteLineAsync(exception.Message).ConfigureAwait(false);
            return 1;
        }
    }

    public static async Task<string?> TryResolveApiKeyAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        if (parseResult.GetValue(CliOptions.ApiKey) is { Length: > 0 } fromOption)
        {
            return fromOption;
        }

        foreach (var environmentVariable in ApiKeyEnvironmentVariables)
        {
            if (Environment.GetEnvironmentVariable(environmentVariable) is { Length: > 0 } fromEnvironment)
            {
                return fromEnvironment;
            }
        }

        return await ReadUserSecretAsync(UserSecretApiKeyName, cancellationToken).ConfigureAwait(false);
    }

    public static async Task<AuthStatusInfo> GetAuthStatusAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        if (parseResult.GetValue(CliOptions.ApiKey) is { Length: > 0 } fromOption)
        {
            return new AuthStatusInfo(true, "option", MaskSecret(fromOption), null);
        }

        foreach (var environmentVariable in ApiKeyEnvironmentVariables)
        {
            if (Environment.GetEnvironmentVariable(environmentVariable) is { Length: > 0 } fromEnvironment)
            {
                return new AuthStatusInfo(true, $"environment:{environmentVariable}", MaskSecret(fromEnvironment), null);
            }
        }

        var userSecret = await ReadUserSecretAsync(UserSecretApiKeyName, cancellationToken).ConfigureAwait(false);
        return string.IsNullOrWhiteSpace(userSecret)
            ? new AuthStatusInfo(false, "none", null, GetUserSecretsPath())
            : new AuthStatusInfo(true, "user-secrets", MaskSecret(userSecret), GetUserSecretsPath());
    }

    public static async Task WriteUserSecretAsync(string name, string value, CancellationToken cancellationToken = default)
    {
        var path = GetUserSecretsPath();
        var directory = Path.GetDirectoryName(path);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        var values = await ReadUserSecretsAsync(cancellationToken).ConfigureAwait(false);
        values[name] = value;
        var json = PrettyJson(JsonSerializer.Serialize(values, UserSecretsJsonContext.Default.DictionaryStringString));
        await File.WriteAllTextAsync(path, json, cancellationToken).ConfigureAwait(false);
    }

    public static async Task ClearUserSecretAsync(string name, CancellationToken cancellationToken = default)
    {
        var path = GetUserSecretsPath();
        if (!File.Exists(path))
        {
            return;
        }

        var values = await ReadUserSecretsAsync(cancellationToken).ConfigureAwait(false);
        if (!values.Remove(name))
        {
            return;
        }

        var json = PrettyJson(JsonSerializer.Serialize(values, UserSecretsJsonContext.Default.DictionaryStringString));
        await File.WriteAllTextAsync(path, json, cancellationToken).ConfigureAwait(false);
    }

    public static string GetUserSecretApiKeyName() => UserSecretApiKeyName;

    public static string GetUserSecretsPath()
    {
        var userSecretsRoot = OperatingSystem.IsWindows()
            ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft", "UserSecrets")
            : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".microsoft", "usersecrets");

        return Path.Combine(userSecretsRoot, UserSecretsId, "secrets.json");
    }

    public static async Task<T> ReadRequestAsync<T>(ParseResult parseResult, Option<string?> requestJsonOption, Option<string?> requestFileOption, JsonSerializerContext context, CancellationToken cancellationToken = default)
    {
        var requestJson = parseResult.GetValue(requestJsonOption);
        if (string.IsNullOrWhiteSpace(requestJson))
        {
            var requestFile = parseResult.GetValue(requestFileOption);
            if (string.IsNullOrWhiteSpace(requestFile))
            {
                throw new CliException("Specify --request-json or --request-file.");
            }

            requestJson = requestFile == "-"
                ? await Console.In.ReadToEndAsync(cancellationToken).ConfigureAwait(false)
                : await File.ReadAllTextAsync(requestFile, cancellationToken).ConfigureAwait(false);
        }

        var value = JsonSerializer.Deserialize(requestJson, typeof(T), context);
        return value is T typed
            ? typed
            : throw new CliException($"Unable to deserialize request JSON as {typeof(T).Name}.");
    }

    public static async Task WriteJsonAsync<T>(ParseResult parseResult, T value, JsonSerializerContext context, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(value, typeof(T), context);
        await WriteTextAsync(parseResult, PrettyJson(json), cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public static async Task WriteJsonLineAsync<T>(ParseResult parseResult, T value, JsonSerializerContext context, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(value, typeof(T), context);
        await WriteTextAsync(parseResult, json + Environment.NewLine, append: true, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public static async Task WriteSuccessAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        await WriteTextAsync(parseResult, "{\n  \"success\": true\n}", cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public static async Task WriteBinaryAsync(ParseResult parseResult, byte[] bytes, CancellationToken cancellationToken = default)
    {
        var outputPath = parseResult.GetValue(CliOptions.Output);
        if (string.IsNullOrWhiteSpace(outputPath))
        {
            throw new CliException("Binary responses require --output.");
        }

        await WriteBytesAsync(outputPath, bytes, cancellationToken).ConfigureAwait(false);
    }

    public static async Task WriteStreamAsync(ParseResult parseResult, Stream stream, CancellationToken cancellationToken = default)
    {
        var outputPath = parseResult.GetValue(CliOptions.Output);
        if (string.IsNullOrWhiteSpace(outputPath))
        {
            throw new CliException("Stream responses require --output.");
        }

        var directory = Path.GetDirectoryName(outputPath);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        var file = File.Create(outputPath);
        await using (file.ConfigureAwait(false))
        {
            await stream.CopyToAsync(file, cancellationToken).ConfigureAwait(false);
        }
    }

    public static string MaskSecret(string secret)
    {
        return secret.Length <= 8 ? new string('*', secret.Length) : $"{secret[..4]}...{secret[^4..]}";
    }

    private static Uri? ResolveBaseUri(ParseResult parseResult)
    {
        var baseUrl = parseResult.GetValue(CliOptions.BaseUrl);
        if (string.IsNullOrWhiteSpace(baseUrl))
        {
            baseUrl = Environment.GetEnvironmentVariable("OPENAI_BASE_URL");
        }

        return string.IsNullOrWhiteSpace(baseUrl) ? null : new Uri(baseUrl, UriKind.Absolute);
    }

    private static async Task<string?> ReadUserSecretAsync(string name, CancellationToken cancellationToken = default)
    {
        var values = await ReadUserSecretsAsync(cancellationToken).ConfigureAwait(false);
        return values.TryGetValue(name, out var value) && !string.IsNullOrWhiteSpace(value) ? value : null;
    }

    private static async Task<Dictionary<string, string>> ReadUserSecretsAsync(CancellationToken cancellationToken = default)
    {
        var path = GetUserSecretsPath();
        if (!File.Exists(path))
        {
            return new Dictionary<string, string>(StringComparer.Ordinal);
        }

        var json = await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false);
        if (string.IsNullOrWhiteSpace(json))
        {
            return new Dictionary<string, string>(StringComparer.Ordinal);
        }

        return JsonSerializer.Deserialize(json, UserSecretsJsonContext.Default.DictionaryStringString) ??
            new Dictionary<string, string>(StringComparer.Ordinal);
    }

    private static async Task WriteTextAsync(ParseResult parseResult, string text, bool append = false, CancellationToken cancellationToken = default)
    {
        var outputPath = parseResult.GetValue(CliOptions.Output);
        if (string.IsNullOrWhiteSpace(outputPath))
        {
            await Console.Out.WriteAsync(text).ConfigureAwait(false);
            if (!text.EndsWith(Environment.NewLine, StringComparison.Ordinal))
            {
                await Console.Out.WriteLineAsync().ConfigureAwait(false);
            }

            return;
        }

        var directory = Path.GetDirectoryName(outputPath);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        if (append)
        {
            await File.AppendAllTextAsync(outputPath, text, cancellationToken).ConfigureAwait(false);
        }
        else
        {
            await File.WriteAllTextAsync(outputPath, text, cancellationToken).ConfigureAwait(false);
        }
    }

    private static async Task WriteBytesAsync(string outputPath, byte[] bytes, CancellationToken cancellationToken = default)
    {
        var directory = Path.GetDirectoryName(outputPath);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        await File.WriteAllBytesAsync(outputPath, bytes, cancellationToken).ConfigureAwait(false);
    }

    private static async Task WriteApiExceptionAsync(global::tryAGI.OpenAI.ApiException exception)
    {
        var builder = new StringBuilder();
        builder.Append("API error ");
        builder.Append((int)exception.StatusCode);
        builder.Append(": ");
        builder.Append(exception.Message);
        if (!string.IsNullOrWhiteSpace(exception.ResponseBody))
        {
            builder.AppendLine();
            builder.Append(exception.ResponseBody);
        }

        await Console.Error.WriteLineAsync(builder.ToString()).ConfigureAwait(false);
    }

    private static string PrettyJson(string json)
    {
        using var document = JsonDocument.Parse(json);
        using var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true }))
        {
            document.WriteTo(writer);
        }

        return Encoding.UTF8.GetString(stream.ToArray());
    }
}

internal sealed record AuthStatusInfo(bool Authenticated, string Source, string? ApiKeyHint, string? Path);

[JsonSerializable(typeof(Dictionary<string, string>))]
internal sealed partial class UserSecretsJsonContext : JsonSerializerContext;