using System.CommandLine;
using System.CommandLine.Parsing;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace tryAGI.OpenAI.Cli;

internal static class CliRuntime
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        WriteIndented = true,
    };

    public static async Task<string> ResolveApiKeyAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        var fromOption = parseResult.GetValue(CliOptions.ApiKey);
        if (!string.IsNullOrWhiteSpace(fromOption))
        {
            return fromOption;
        }

        var fromEnvironment = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
        if (!string.IsNullOrWhiteSpace(fromEnvironment))
        {
            return fromEnvironment;
        }

        var fromUserSecrets = await ReadUserSecretAsync("OPENAI_API_KEY", cancellationToken).ConfigureAwait(false);
        if (!string.IsNullOrWhiteSpace(fromUserSecrets))
        {
            return fromUserSecrets;
        }

        throw new CliException(
            "No OpenAI API key found. Pass --api-key, set $OPENAI_API_KEY, or run: tryagi-openai auth set <your-key>.");
    }

    public static string? ResolveBaseUrl(ParseResult parseResult)
    {
        var fromOption = parseResult.GetValue(CliOptions.BaseUrl);
        if (!string.IsNullOrWhiteSpace(fromOption))
        {
            return fromOption;
        }

        var fromEnvironment = Environment.GetEnvironmentVariable("OPENAI_BASE_URL");
        return string.IsNullOrWhiteSpace(fromEnvironment) ? null : fromEnvironment;
    }

    public static async Task<OpenAiClient> CreateClientAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
    {
        var apiKey = await ResolveApiKeyAsync(parseResult, cancellationToken).ConfigureAwait(false);
        var baseUrl = ResolveBaseUrl(parseResult);
        return string.IsNullOrWhiteSpace(baseUrl)
            ? new OpenAiClient(apiKey)
            : new OpenAiClient(apiKey, baseUri: new Uri(baseUrl, UriKind.Absolute));
    }

    public static async Task WriteOutputAsync(ParseResult parseResult, string humanText, object? jsonValue, CancellationToken cancellationToken = default)
    {
        var useJson = parseResult.GetValue(CliOptions.Json);
        var outputPath = parseResult.GetValue(CliOptions.Output);

        var rendered = useJson && jsonValue is not null
            ? SerializeJson(jsonValue)
            : humanText;

        if (string.IsNullOrWhiteSpace(outputPath))
        {
            await Console.Out.WriteAsync(rendered).ConfigureAwait(false);
            if (!rendered.EndsWith(Environment.NewLine, StringComparison.Ordinal))
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

        await File.WriteAllTextAsync(outputPath, rendered, cancellationToken).ConfigureAwait(false);
    }

    public static string SerializeJson(object value)
    {
        return JsonSerializer.Serialize(value, JsonOptions);
    }

    public static string MaskSecret(string secret)
    {
        if (string.IsNullOrWhiteSpace(secret))
        {
            return string.Empty;
        }

        return secret.Length <= 8
            ? new string('*', secret.Length)
            : $"{secret[..4]}...{secret[^4..]}";
    }

    public static string FormatApiException(ApiException exception)
    {
        var builder = new StringBuilder();
        builder.Append("Request failed (");
        builder.Append((int)exception.StatusCode);
        builder.Append(')');

        if (!string.IsNullOrWhiteSpace(exception.ResponseBody))
        {
            builder.AppendLine();
            builder.Append(exception.ResponseBody);
        }
        else if (!string.IsNullOrWhiteSpace(exception.Message))
        {
            builder.AppendLine();
            builder.Append(exception.Message);
        }

        return builder.ToString();
    }

    public static string GetUserSecretsPath()
    {
        // dotnet user-secrets stores at:
        //   $APPDATA\Microsoft\UserSecrets\<id>\secrets.json   (Windows)
        //   ~/.microsoft/usersecrets/<id>/secrets.json          (Unix)
        if (OperatingSystem.IsWindows())
        {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appData, "Microsoft", "UserSecrets", "tryAGI.OpenAI.CLI", "secrets.json");
        }

        var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        return Path.Combine(home, ".microsoft", "usersecrets", "tryAGI.OpenAI.CLI", "secrets.json");
    }

    public static async Task<string?> ReadUserSecretAsync(string key, CancellationToken cancellationToken = default)
    {
        var path = GetUserSecretsPath();
        if (!File.Exists(path))
        {
            return null;
        }

        try
        {
            var content = await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false);
            var node = JsonNode.Parse(content);
            return node?[key]?.GetValue<string>();
        }
        catch (JsonException)
        {
            return null;
        }
    }

    public static async Task WriteUserSecretAsync(string key, string value, CancellationToken cancellationToken = default)
    {
        var path = GetUserSecretsPath();
        var directory = Path.GetDirectoryName(path);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        JsonObject root;
        if (File.Exists(path))
        {
            var existing = await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false);
            try
            {
                root = JsonNode.Parse(existing) as JsonObject ?? new JsonObject();
            }
            catch (JsonException)
            {
                root = new JsonObject();
            }
        }
        else
        {
            root = new JsonObject();
        }

        root[key] = value;
        await File.WriteAllTextAsync(path, root.ToJsonString(JsonOptions), cancellationToken).ConfigureAwait(false);
    }

    public static async Task<bool> ClearUserSecretAsync(string key, CancellationToken cancellationToken = default)
    {
        var path = GetUserSecretsPath();
        if (!File.Exists(path))
        {
            return false;
        }

        var existing = await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false);
        JsonObject? root;
        try
        {
            root = JsonNode.Parse(existing) as JsonObject;
        }
        catch (JsonException)
        {
            return false;
        }

        if (root is null || !root.Remove(key))
        {
            return false;
        }

        await File.WriteAllTextAsync(path, root.ToJsonString(JsonOptions), cancellationToken).ConfigureAwait(false);
        return true;
    }

    public static Func<ParseResult, CancellationToken, Task<int>> Wrap(Func<ParseResult, CancellationToken, Task> action)
    {
        return async (parseResult, cancellationToken) =>
        {
            try
            {
                await action(parseResult, cancellationToken).ConfigureAwait(false);
                return 0;
            }
            catch (CliException ex)
            {
                await Console.Error.WriteLineAsync(ex.Message).ConfigureAwait(false);
                return 1;
            }
            catch (ApiException ex)
            {
                await Console.Error.WriteLineAsync(FormatApiException(ex)).ConfigureAwait(false);
                return 1;
            }
            catch (OperationCanceledException)
            {
                await Console.Error.WriteLineAsync("Canceled.").ConfigureAwait(false);
                return 130;
            }
        };
    }

    public static string GetRequiredOption(ParseResult parseResult, Option<string> option)
    {
        return parseResult.GetValue(option)
            ?? throw new CliException($"Option '{option.Name}' is required.");
    }

    public static string GetRequiredArgument(ParseResult parseResult, Argument<string> argument)
    {
        return parseResult.GetValue(argument)
            ?? throw new CliException($"Argument '{argument.Name}' is required.");
    }

    public static async Task<string> ReadInputOrFileAsync(string value, CancellationToken cancellationToken = default)
    {
        if (value == "-")
        {
            return await Console.In.ReadToEndAsync(cancellationToken).ConfigureAwait(false);
        }

        if (File.Exists(value))
        {
            return await File.ReadAllTextAsync(value, cancellationToken).ConfigureAwait(false);
        }

        return value;
    }

    public static void AppendInvariant(StringBuilder builder, FormattableString value)
    {
        builder.AppendLine(value.ToString(CultureInfo.InvariantCulture));
    }
}
