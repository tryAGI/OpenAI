#nullable enable

using System.CommandLine;
using System.CommandLine.Parsing;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace tryAGI.OpenAI.Cli.GeneratedApi;

internal static class CliRuntime
{
    private const string UserSecretsId = "tryAGI.OpenAI.CLI";
    private const string UserSecretApiKeyName = "OPENAI_API_KEY";
    private static readonly string[] ApiKeyEnvironmentVariables = [@"OPENAI_API_KEY"];
    private const string CredentialFileDirectoryName = ".open-ai";

    public static async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.OpenAiClient> CreateClientAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        var apiKey = await TryResolveApiKeyAsync(parseResult, cancellationToken).ConfigureAwait(false);
        var authorizations = string.IsNullOrWhiteSpace(apiKey)
            ? new global::System.Collections.Generic.List<global::tryAGI.OpenAI.EndPointAuthorization>()
            : new global::System.Collections.Generic.List<global::tryAGI.OpenAI.EndPointAuthorization>
            {
        CreateAuthorization(
            type: "Http",
            schemeId: "ApiKeyAuth",
            location: "Header",
            name: "Bearer",
            value: apiKey),
            };
        var baseUri = ResolveBaseUri(parseResult);

        return new global::tryAGI.OpenAI.OpenAiClient(
            httpClient: null,
            baseUri: baseUri,
            authorizations: authorizations,
            disposeHttpClient: true);
    }

    private static global::tryAGI.OpenAI.EndPointAuthorization CreateAuthorization(
        string type,
        string schemeId,
        string location,
        string name,
        string value)
    {
        var authorization = new global::tryAGI.OpenAI.EndPointAuthorization
        {
            Type = type,
            Location = location,
            Name = name,
            Value = value,
        };

        var schemeIdProperty = typeof(global::tryAGI.OpenAI.EndPointAuthorization).GetProperty("SchemeId");
        if (schemeIdProperty?.CanWrite == true)
        {
            schemeIdProperty.SetValue(authorization, schemeId);
        }

        return authorization;
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Design",
        "CA1031:Do not catch general exception types",
        Justification = "Generated CLI commands map unexpected failures to a stable exit code.")]
    public static async global::System.Threading.Tasks.Task<int> RunAsync(Func<global::System.Threading.Tasks.Task> action, CancellationToken cancellationToken = default)
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

    public static async global::System.Threading.Tasks.Task<string?> TryResolveApiKeyAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        var probe = await ProbeAuthAsync(parseResult, cancellationToken).ConfigureAwait(false);
        return probe.Active?.RawValue;
    }

    public static async global::System.Threading.Tasks.Task<AuthStatusInfo> GetAuthStatusAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        var probe = await ProbeAuthAsync(parseResult, cancellationToken).ConfigureAwait(false);
        return new AuthStatusInfo(
            Authenticated: probe.Active is not null,
            Source: probe.Active?.DisplayName ?? "none",
            ApiKeyHint: probe.Active is { RawValue.Length: > 0 } active ? MaskSecret(active.RawValue) : null,
            Path: probe.Active?.Path,
            Sources: probe.Sources
                .Select(static source => new AuthSourceStatus(
                    source.DisplayName,
                    source.Present,
                    source.Present ? CliRuntime.MaskSecret(source.RawValue!) : null,
                    source.Path))
                .ToArray());
    }

    public static async global::System.Threading.Tasks.Task WriteUserSecretAsync(string name, string value, CancellationToken cancellationToken = default)
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

    public static async global::System.Threading.Tasks.Task ClearUserSecretAsync(string name, CancellationToken cancellationToken = default)
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

    public static string? GetCredentialFilePath()
    {
        if (string.IsNullOrWhiteSpace(CredentialFileDirectoryName))
        {
            return null;
        }

        var userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        return string.IsNullOrWhiteSpace(userProfile)
            ? null
            : Path.Combine(userProfile, CredentialFileDirectoryName, "apiKey.txt");
    }

    public static bool WasSpecified(ParseResult parseResult, Symbol symbol)
    {
        return parseResult.GetResult(symbol) is not null;
    }

    public static Option<bool?> CreateNullableBoolOption(string name, string description, params string[] aliases)
    {
        var option = new Option<bool?>(name, aliases)
        {
            Description = description + " Specify true/false; presence alone implies true; omit to inherit.",
            Arity = ArgumentArity.ZeroOrOne,
        };

        option.CustomParser = result =>
        {
            if (result.Tokens.Count == 0)
            {
                return true;
            }

            if (result.Tokens.Count == 1)
            {
                var raw = result.Tokens[0].Value.Trim();
                if (bool.TryParse(raw, out var boolValue))
                {
                    return boolValue;
                }

                switch (raw.ToUpperInvariant())
                {
                    case "1":
                    case "YES":
                    case "Y":
                    case "ON":
                        return true;
                    case "0":
                    case "NO":
                    case "N":
                    case "OFF":
                        return false;
                }
            }

            result.AddError($"Option '{name}' expects true or false.");
            return null;
        };

        return option;
    }

    public static TimeSpan ParseDuration(string value, string optionName)
    {
        if (TimeSpan.TryParse(value, CultureInfo.InvariantCulture, out var timeSpan))
        {
            return timeSpan;
        }

        if (value.EndsWith("ms", StringComparison.OrdinalIgnoreCase) &&
            double.TryParse(value[..^2], NumberStyles.Float, CultureInfo.InvariantCulture, out var milliseconds))
        {
            return TimeSpan.FromMilliseconds(milliseconds);
        }

        if (EndsWithUnit(value, 's') &&
            double.TryParse(value[..^1], NumberStyles.Float, CultureInfo.InvariantCulture, out var seconds))
        {
            return TimeSpan.FromSeconds(seconds);
        }

        if (EndsWithUnit(value, 'm') &&
            double.TryParse(value[..^1], NumberStyles.Float, CultureInfo.InvariantCulture, out var minutes))
        {
            return TimeSpan.FromMinutes(minutes);
        }

        if (EndsWithUnit(value, 'h') &&
            double.TryParse(value[..^1], NumberStyles.Float, CultureInfo.InvariantCulture, out var hours))
        {
            return TimeSpan.FromHours(hours);
        }

        throw new CliException($"Unable to parse duration '{value}' for option '{optionName}'.");
    }



    public static async global::System.Threading.Tasks.Task<string?> ReadInputAsync(
        ParseResult parseResult,
        Option<string?> inputOption,
        Option<string?> requestJsonOption,
        Option<string?> requestFileOption,
        bool required = false,
        CancellationToken cancellationToken = default)
    {
        var hasInput = WasSpecified(parseResult, inputOption);
        var hasRequestJson = WasSpecified(parseResult, requestJsonOption);
        var hasRequestFile = WasSpecified(parseResult, requestFileOption);
        var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);

        if (specifiedCount > 1)
        {
            throw new CliException("Specify at most one of --input, --request-json, or --request-file.");
        }

        if (specifiedCount == 0)
        {
            if (required)
            {
                throw new CliException("Specify --input, --request-json, or --request-file.");
            }

            return null;
        }

        if (hasRequestJson)
        {
            await WriteDeprecatedOptionWarningAsync("--request-json", "--input").ConfigureAwait(false);
            return parseResult.GetValue(requestJsonOption);
        }

        if (hasRequestFile)
        {
            await WriteDeprecatedOptionWarningAsync("--request-file", "--input").ConfigureAwait(false);
            return await ReadFileOrStdinAsync(parseResult.GetValue(requestFileOption)!, cancellationToken).ConfigureAwait(false);
        }

        return await ReadFlexibleInputAsync(parseResult.GetValue(inputOption)!, cancellationToken).ConfigureAwait(false);
    }

    public static async global::System.Threading.Tasks.Task<T> ReadRequestAsync<T>(
        ParseResult parseResult,
        Option<string?> inputOption,
        Option<string?> requestJsonOption,
        Option<string?> requestFileOption,
        JsonSerializerContext context,
        CancellationToken cancellationToken = default)
    {
        var requestJson = await ReadInputAsync(
            parseResult,
            inputOption,
            requestJsonOption,
            requestFileOption,
            required: true,
            cancellationToken).ConfigureAwait(false);

        var value = JsonSerializer.Deserialize(requestJson ?? throw new CliException("Request input is required."), typeof(T), context);
        return value is T typed
            ? typed
            : throw new CliException($"Unable to deserialize request JSON as {typeof(T).Name}.");
    }

    public static async global::System.Threading.Tasks.Task<T?> ReadRequestOrDefaultAsync<T>(
        ParseResult parseResult,
        Option<string?> inputOption,
        Option<string?> requestJsonOption,
        Option<string?> requestFileOption,
        JsonSerializerContext context,
        CancellationToken cancellationToken = default)
    {
        var requestJson = await ReadInputAsync(
            parseResult,
            inputOption,
            requestJsonOption,
            requestFileOption,
            cancellationToken: cancellationToken).ConfigureAwait(false);
        if (string.IsNullOrWhiteSpace(requestJson))
        {
            return default;
        }

        var value = JsonSerializer.Deserialize(requestJson!, typeof(T), context);
        return value is T typed
            ? typed
            : throw new CliException($"Unable to deserialize request JSON as {typeof(T).Name}.");
    }

    public static T DeserializeJsonValue<T>(string json, JsonSerializerContext context)
    {
        _ = context;
        return JsonSerializer.Deserialize<T>(json) ??
            throw new CliException($"Unable to deserialize generated CLI value as {typeof(T).Name}.");
    }

    public static string SerializeKeyValuePairs(IEnumerable<string> pairs)
    {
        var objectNode = new JsonObject();
        foreach (var pair in pairs)
        {
            var separatorIndex = pair.IndexOf('=', StringComparison.Ordinal);
            if (separatorIndex <= 0 || separatorIndex == pair.Length - 1)
            {
                throw new CliException($"Expected KEY=VALUE but received '{pair}'.");
            }

            var key = pair[..separatorIndex].Trim();
            var value = pair[(separatorIndex + 1)..].Trim();
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new CliException($"Expected KEY=VALUE but received '{pair}'.");
            }

            objectNode[key] = value;
        }

        return objectNode.ToJsonString();
    }

    public static string SerializeStringArray(IEnumerable<string> values)
    {
        return JsonSerializer.Serialize(values.ToArray());
    }

    public static async global::System.Threading.Tasks.Task WriteJsonAsync<T>(ParseResult parseResult, T value, JsonSerializerContext context, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(value, typeof(T), context);
        await WriteTextAsync(parseResult, PrettyJson(json), cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public static async global::System.Threading.Tasks.Task WriteJsonLineAsync<T>(ParseResult parseResult, T value, JsonSerializerContext context, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(value, typeof(T), context);
        await WriteTextAsync(parseResult, json + Environment.NewLine, append: true, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public static async global::System.Threading.Tasks.Task WriteResponseAsync<T>(
        ParseResult parseResult,
        T value,
        JsonSerializerContext context,
        Func<ParseResult, T, JsonSerializerContext, bool, string>? formatter = null,
        CancellationToken cancellationToken = default)
    {
        if (parseResult.GetValue(CliOptions.Json))
        {
            await WriteJsonAsync(parseResult, value, context, cancellationToken).ConfigureAwait(false);
            return;
        }

        var truncateLongStrings = string.IsNullOrWhiteSpace(parseResult.GetValue(CliOptions.Output));
        var text = formatter is null
            ? FormatHumanReadable(value, context, truncateLongStrings)
            : formatter(parseResult, value, context, truncateLongStrings);
        await WriteTextAsync(parseResult, text, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public static async global::System.Threading.Tasks.Task WriteResponseLineAsync<T>(
        ParseResult parseResult,
        T value,
        JsonSerializerContext context,
        Func<ParseResult, T, JsonSerializerContext, bool, string>? formatter = null,
        CancellationToken cancellationToken = default)
    {
        if (parseResult.GetValue(CliOptions.Json))
        {
            await WriteJsonLineAsync(parseResult, value, context, cancellationToken).ConfigureAwait(false);
            return;
        }

        var truncateLongStrings = string.IsNullOrWhiteSpace(parseResult.GetValue(CliOptions.Output));
        var text = formatter is null
            ? FormatHumanReadable(value, context, truncateLongStrings)
            : formatter(parseResult, value, context, truncateLongStrings);
        await WriteTextAsync(parseResult, text + Environment.NewLine, append: true, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public static async global::System.Threading.Tasks.Task<bool> TryWriteOutputDirectoryAsync<T>(
        ParseResult parseResult,
        T value,
        JsonSerializerContext context,
        string itemsPropertyName,
        CancellationToken cancellationToken = default)
    {
        var outputDirectory = parseResult.GetValue(CliOptions.OutputDirectory);
        if (string.IsNullOrWhiteSpace(outputDirectory))
        {
            return false;
        }

        var rootNode = ToJsonNode(value, typeof(T), context);
        var items = itemsPropertyName == "$self"
            ? rootNode as JsonArray
            : rootNode?[itemsPropertyName] as JsonArray;
        if (items is null)
        {
            throw new CliException("The response does not contain a writable item collection for --output-dir.");
        }

        await WriteItemFilesAsync(outputDirectory, items, cancellationToken).ConfigureAwait(false);
        return true;
    }

    public static async global::System.Threading.Tasks.Task WriteSuccessAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        if (parseResult.GetValue(CliOptions.Json))
        {
            await WriteTextAsync(parseResult, "{\n  \"success\": true\n}", cancellationToken: cancellationToken).ConfigureAwait(false);
            return;
        }

        await WriteTextAsync(parseResult, "success: true", cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public static async global::System.Threading.Tasks.Task WriteBinaryAsync(ParseResult parseResult, byte[] bytes, CancellationToken cancellationToken = default)
    {
        var outputPath = parseResult.GetValue(CliOptions.Output);
        if (string.IsNullOrWhiteSpace(outputPath))
        {
            throw new CliException("Binary responses require --output.");
        }

        await WriteBytesAsync(outputPath, bytes, cancellationToken).ConfigureAwait(false);
    }

    public static async global::System.Threading.Tasks.Task WriteStreamAsync(ParseResult parseResult, Stream stream, CancellationToken cancellationToken = default)
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
        return secret.Length < 12 ? "***" : $"{secret[..4]}...{secret[^4..]}";
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

    private static async global::System.Threading.Tasks.Task<string?> ReadUserSecretAsync(string name, CancellationToken cancellationToken = default)
    {
        var values = await ReadUserSecretsAsync(cancellationToken).ConfigureAwait(false);
        return values.TryGetValue(name, out var value) && !string.IsNullOrWhiteSpace(value) ? value : null;
    }

    private static async global::System.Threading.Tasks.Task<string?> ReadCredentialFileAsync(CancellationToken cancellationToken = default)
    {
        var path = GetCredentialFilePath();
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
        {
            return null;
        }

        var value = await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false);
        return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
    }

    private static async global::System.Threading.Tasks.Task<Dictionary<string, string>> ReadUserSecretsAsync(CancellationToken cancellationToken = default)
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

    private static async global::System.Threading.Tasks.Task WriteTextAsync(ParseResult parseResult, string text, bool append = false, CancellationToken cancellationToken = default)
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

    private static async global::System.Threading.Tasks.Task WriteBytesAsync(string outputPath, byte[] bytes, CancellationToken cancellationToken = default)
    {
        var directory = Path.GetDirectoryName(outputPath);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        await File.WriteAllBytesAsync(outputPath, bytes, cancellationToken).ConfigureAwait(false);
    }

    private static bool EndsWithUnit(string value, char unit)
    {
        return value.Length > 1 && value[^1] == unit;
    }

    private static async global::System.Threading.Tasks.Task WriteDeprecatedOptionWarningAsync(string oldOption, string replacement)
    {
        await Console.Error.WriteLineAsync($"Warning: {oldOption} is deprecated; use {replacement}.").ConfigureAwait(false);
    }

    private static async global::System.Threading.Tasks.Task<string> ReadFlexibleInputAsync(string input, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new CliException("Input cannot be empty.");
        }

        if (input == "-")
        {
            return await Console.In.ReadToEndAsync(cancellationToken).ConfigureAwait(false);
        }

        var trimmed = input.TrimStart();
        if (trimmed.StartsWith('{') || trimmed.StartsWith('['))
        {
            return input;
        }

        return await ReadFileOrStdinAsync(input, cancellationToken).ConfigureAwait(false);
    }

    private static async global::System.Threading.Tasks.Task<string> ReadFileOrStdinAsync(string pathOrDash, CancellationToken cancellationToken = default)
    {
        if (pathOrDash == "-")
        {
            return await Console.In.ReadToEndAsync(cancellationToken).ConfigureAwait(false);
        }

        if (!File.Exists(pathOrDash))
        {
            throw new CliException($"File not found: {pathOrDash}");
        }

        return await File.ReadAllTextAsync(pathOrDash, cancellationToken).ConfigureAwait(false);
    }

    private static JsonNode? ToJsonNode<T>(T value, Type type, JsonSerializerContext context)
    {
        var json = JsonSerializer.Serialize(value, type, context);
        return JsonNode.Parse(json);
    }

    private static JsonElement ToJsonElement<T>(T value, JsonSerializerContext context)
    {
        var json = JsonSerializer.Serialize(value, typeof(T), context);
        using var document = JsonDocument.Parse(json);
        return document.RootElement.Clone();
    }

    public static string FormatHumanReadable<T>(
        T value,
        JsonSerializerContext context,
        bool truncateLongStrings,
        IReadOnlyDictionary<string, CliFormatHint>? formatHints = null)
    {
        var element = ToJsonElement(value, context);
        var builder = new StringBuilder();
        AppendFormattedValue(builder, null, element, 0, truncateLongStrings, formatHints, path: null);
        return builder.ToString().TrimEnd();
    }

    private static void AppendFormattedValue(
        StringBuilder builder,
        string? name,
        JsonElement element,
        int indent,
        bool truncateLongStrings,
        IReadOnlyDictionary<string, CliFormatHint>? formatHints,
        string? path)
    {
        if (ShouldHide(path, formatHints))
        {
            return;
        }

        if (element.ValueKind == JsonValueKind.String &&
            HasFormatHint(path, CliFormatHint.Code, formatHints))
        {
            AppendCodeBlock(builder, name, element.GetString() ?? string.Empty, indent);
            return;
        }

        switch (element.ValueKind)
        {
            case JsonValueKind.Object:
                AppendFormattedObject(builder, name, element, indent, truncateLongStrings, formatHints, path);
                break;
            case JsonValueKind.Array:
                AppendFormattedArray(builder, name, element, indent, truncateLongStrings, formatHints, path);
                break;
            default:
                AppendLine(builder, indent, name is null ? FormatScalar(element, truncateLongStrings) : $"{name}: {FormatScalar(element, truncateLongStrings)}");
                break;
        }
    }

    private static void AppendFormattedObject(
        StringBuilder builder,
        string? name,
        JsonElement element,
        int indent,
        bool truncateLongStrings,
        IReadOnlyDictionary<string, CliFormatHint>? formatHints,
        string? path)
    {
        if (name is not null)
        {
            AppendLine(builder, indent, $"{name}:");
            indent += 2;
        }

        var properties = element.EnumerateObject()
            .OrderByDescending(property => HasFormatHint(CombinePath(path, property.Name), CliFormatHint.Key, formatHints))
            .ThenBy(property => property.Name, StringComparer.OrdinalIgnoreCase)
            .ToArray();
        foreach (var property in properties)
        {
            AppendFormattedValue(
                builder,
                property.Name,
                property.Value,
                indent,
                truncateLongStrings,
                formatHints,
                CombinePath(path, property.Name));
        }
    }

    private static void AppendFormattedArray(
        StringBuilder builder,
        string? name,
        JsonElement element,
        int indent,
        bool truncateLongStrings,
        IReadOnlyDictionary<string, CliFormatHint>? formatHints,
        string? path)
    {
        var items = element.EnumerateArray().ToArray();
        if (name is not null)
        {
            AppendLine(builder, indent, $"{name}:");
            indent += 2;
        }

        if (items.Length == 0)
        {
            AppendLine(builder, indent, "[]");
            return;
        }

        if (items.All(static item => item.ValueKind is not JsonValueKind.Object and not JsonValueKind.Array))
        {
            foreach (var item in items)
            {
                AppendLine(builder, indent, $"- {FormatScalar(item, truncateLongStrings)}");
            }

            return;
        }

        for (var index = 0; index < items.Length; index++)
        {
            AppendLine(builder, indent, $"{index + 1}.");
            AppendFormattedValue(builder, null, items[index], indent + 2, truncateLongStrings, formatHints, path);
        }
    }

    private static string FormatScalar(JsonElement element, bool truncateLongStrings)
    {
        return element.ValueKind switch
        {
            JsonValueKind.String => FormatStringScalar(element.GetString() ?? string.Empty, truncateLongStrings),
            JsonValueKind.True => "true",
            JsonValueKind.False => "false",
            JsonValueKind.Number => element.GetRawText(),
            JsonValueKind.Null => "null",
            _ => element.GetRawText(),
        };
    }

    private static string FormatStringScalar(string value, bool truncateLongStrings)
    {
        if (DateTimeOffset.TryParse(
                value,
                CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal,
                out var dateTimeOffset))
        {
            return dateTimeOffset.UtcDateTime.ToString("yyyy-MM-dd HH:mm:ss 'UTC'", CultureInfo.InvariantCulture);
        }

        if (truncateLongStrings && value.Length > 80)
        {
            return value[..77] + "...";
        }

        return value;
    }

    private static bool ShouldHide(string? path, IReadOnlyDictionary<string, CliFormatHint>? formatHints)
    {
        return HasFormatHint(path, CliFormatHint.Hidden, formatHints);
    }

    private static bool HasFormatHint(string? path, CliFormatHint expected, IReadOnlyDictionary<string, CliFormatHint>? formatHints)
    {
        return !string.IsNullOrWhiteSpace(path) &&
               formatHints is not null &&
               formatHints.TryGetValue(path, out var hint) &&
               hint == expected;
    }

    private static string CombinePath(string? prefix, string segment)
    {
        return string.IsNullOrWhiteSpace(prefix)
            ? segment
            : $"{prefix}.{segment}";
    }

    private static void AppendCodeBlock(StringBuilder builder, string? name, string value, int indent)
    {
        if (name is not null)
        {
            AppendLine(builder, indent, $"{name}:");
            indent += 2;
        }

        foreach (var line in value.Replace("\r\n", "\n", StringComparison.Ordinal).Split('\n'))
        {
            AppendLine(builder, indent, line);
        }
    }

    private static void AppendLine(StringBuilder builder, int indent, string value)
    {
        builder.Append(' ', indent);
        builder.AppendLine(value);
    }

    private static async global::System.Threading.Tasks.Task WriteItemFilesAsync(string outputDirectory, JsonArray items, CancellationToken cancellationToken = default)
    {
        Directory.CreateDirectory(outputDirectory);

        for (var index = 0; index < items.Count; index++)
        {
            if (items[index] is not JsonNode itemNode)
            {
                continue;
            }

            var itemObject = itemNode as JsonObject;
            var baseName = itemObject is null
                ? $"{index + 1:000}"
                : SanitizeFileName(GetOutputItemName(itemObject) ?? $"{index + 1:000}");

            var wroteStructuredFile = false;
            if (itemObject is not null)
            {
                wroteStructuredFile |= await TryWriteTextPropertyAsync(itemObject, outputDirectory, baseName, "markdown", ".md", cancellationToken).ConfigureAwait(false);
                wroteStructuredFile |= await TryWriteTextPropertyAsync(itemObject, outputDirectory, baseName, "html", ".html", cancellationToken).ConfigureAwait(false);
                wroteStructuredFile |= await TryWriteTextPropertyAsync(itemObject, outputDirectory, baseName, "rawHtml", ".raw.html", cancellationToken).ConfigureAwait(false);
                wroteStructuredFile |= await TryWriteTextPropertyAsync(itemObject, outputDirectory, baseName, "raw_html", ".raw.html", cancellationToken).ConfigureAwait(false);
                wroteStructuredFile |= await TryWriteTextPropertyAsync(itemObject, outputDirectory, baseName, "text", ".txt", cancellationToken).ConfigureAwait(false);

                if (TryGetNamedNode(itemObject, out var linksNode, "links") && linksNode is JsonArray links)
                {
                    var linkLines = links
                        .Select(static node => node?.GetValue<string>())
                        .Where(static value => !string.IsNullOrWhiteSpace(value))
                        .ToArray();
                    if (linkLines.Length > 0)
                    {
                        await File.WriteAllTextAsync(
                            Path.Combine(outputDirectory, $"{baseName}.links.txt"),
                            string.Join(Environment.NewLine, linkLines),
                            cancellationToken).ConfigureAwait(false);
                        wroteStructuredFile = true;
                    }
                }
            }

            var json = itemNode.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
            var fileName = wroteStructuredFile
                ? $"{baseName}.metadata.json"
                : $"{baseName}.json";
            await File.WriteAllTextAsync(Path.Combine(outputDirectory, fileName), json, cancellationToken).ConfigureAwait(false);
        }
    }

    private static async global::System.Threading.Tasks.Task<bool> TryWriteTextPropertyAsync(
        JsonObject item,
        string outputDirectory,
        string baseName,
        string propertyName,
        string extension,
        CancellationToken cancellationToken)
    {
        if (!TryGetNamedNode(item, out var node, propertyName))
        {
            return false;
        }

        var value = node?.GetValue<string>();
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        await File.WriteAllTextAsync(
            Path.Combine(outputDirectory, $"{baseName}{extension}"),
            value,
            cancellationToken).ConfigureAwait(false);
        return true;
    }

    private static string? GetOutputItemName(JsonObject item)
    {
        if (TryGetNamedNode(item, out var node, "url", "sourceUrl", "source_url", "id"))
        {
            return node?.GetValue<string>();
        }

        return null;
    }

    private static bool TryGetNamedNode(JsonObject item, out JsonNode? node, params string[] names)
    {
        foreach (var property in item)
        {
            if (names.Any(name => string.Equals(property.Key, name, StringComparison.OrdinalIgnoreCase)))
            {
                node = property.Value;
                return true;
            }
        }

        node = null;
        return false;
    }

    private static string SanitizeFileName(string value)
    {
        var normalized = value
            .Replace("https://", string.Empty, StringComparison.OrdinalIgnoreCase)
            .Replace("http://", string.Empty, StringComparison.OrdinalIgnoreCase)
            .Replace("www.", string.Empty, StringComparison.OrdinalIgnoreCase);

        foreach (var invalid in Path.GetInvalidFileNameChars())
        {
            normalized = normalized.Replace(invalid, '_');
        }

        return normalized;
    }

    private static async global::System.Threading.Tasks.Task WriteApiExceptionAsync(global::tryAGI.OpenAI.ApiException exception)
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

    private static async global::System.Threading.Tasks.Task<AuthProbeResult> ProbeAuthAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        var optionSource = new AuthSourceProbe(
            Source: "option",
            DisplayName: "flag (--api-key)",
            RawValue: parseResult.GetValue(CliOptions.ApiKey),
            Path: null);
        var sources = new List<AuthSourceProbe>();
        sources.Add(optionSource);
        AuthSourceProbe? active = optionSource.Present ? optionSource : null;

        foreach (var environmentVariable in ApiKeyEnvironmentVariables)
        {
            var environmentSource = new AuthSourceProbe(
                Source: $"environment:{environmentVariable}",
                DisplayName: $"env var {environmentVariable}",
                RawValue: Environment.GetEnvironmentVariable(environmentVariable),
                Path: null);
            sources.Add(environmentSource);
            if (active is null && environmentSource.Present)
            {
                active = environmentSource;
            }
        }

        var userSecretsSource = new AuthSourceProbe(
            Source: "user-secrets",
            DisplayName: "user-secrets",
            RawValue: await ReadUserSecretAsync(UserSecretApiKeyName, cancellationToken).ConfigureAwait(false),
            Path: GetUserSecretsPath());
        sources.Add(userSecretsSource);
        if (active is null && userSecretsSource.Present)
        {
            active = userSecretsSource;
        }

        if (GetCredentialFilePath() is { Length: > 0 } credentialFilePath)
        {
            var credentialFileSource = new AuthSourceProbe(
                Source: "credential-file",
                DisplayName: "credential file",
                RawValue: await ReadCredentialFileAsync(cancellationToken).ConfigureAwait(false),
                Path: credentialFilePath);
            sources.Add(credentialFileSource);
            if (active is null && credentialFileSource.Present)
            {
                active = credentialFileSource;
            }
        }

        return new AuthProbeResult(active, [.. sources]);
    }
}

internal enum CliFormatHint
{
    Key,
    Hidden,
    Code,
}

internal sealed record AuthStatusInfo(bool Authenticated, string Source, string? ApiKeyHint, string? Path, AuthSourceStatus[] Sources);
internal sealed record AuthSourceStatus(string DisplayName, bool Present, string? ApiKeyHint, string? Path);
internal sealed record AuthProbeResult(AuthSourceProbe? Active, AuthSourceProbe[] Sources);
internal sealed record AuthSourceProbe(string Source, string DisplayName, string? RawValue, string? Path)
{
    public bool Present => !string.IsNullOrWhiteSpace(RawValue);
}

[JsonSerializable(typeof(AuthStatusInfo))]
[JsonSerializable(typeof(Dictionary<string, string>))]
internal sealed partial class UserSecretsJsonContext : JsonSerializerContext;