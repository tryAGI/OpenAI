using System.CommandLine;
using System.CommandLine.Parsing;

namespace tryAGI.OpenAI.Cli.Commands;

internal static class AuthCommand
{
    public static Command Create()
    {
        var cmd = new Command("auth", "Manage OpenAI API credentials stored in `dotnet user-secrets`.");
        cmd.Subcommands.Add(CreateSetCommand());
        cmd.Subcommands.Add(CreateShowCommand());
        cmd.Subcommands.Add(CreateClearCommand());
        return cmd;
    }

    private static Command CreateSetCommand()
    {
        var keyArg = new Argument<string>("api-key") { Description = "Your OpenAI API key (starts with `sk-`)." };
        var cmd = new Command("set", "Store the OpenAI API key in user-secrets for future `dnx` invocations.");
        cmd.Arguments.Add(keyArg);
        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            var apiKey = CliRuntime.GetRequiredArgument(parseResult, keyArg);
            await CliRuntime.WriteUserSecretAsync("OPENAI_API_KEY", apiKey, cancellationToken).ConfigureAwait(false);
            await Console.Out.WriteLineAsync($"Stored OpenAI API key ({CliRuntime.MaskSecret(apiKey)}) at {CliRuntime.GetUserSecretsPath()}.").ConfigureAwait(false);
        }));
        return cmd;
    }

    private static Command CreateShowCommand()
    {
        var cmd = new Command("show", "Show which credential source is currently resolved.");
        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            var fromOption = parseResult.GetValue(CliOptions.ApiKey);
            if (!string.IsNullOrWhiteSpace(fromOption))
            {
                await Console.Out.WriteLineAsync($"source: --api-key option ({CliRuntime.MaskSecret(fromOption)})").ConfigureAwait(false);
                return;
            }

            var fromEnv = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            if (!string.IsNullOrWhiteSpace(fromEnv))
            {
                await Console.Out.WriteLineAsync($"source: $OPENAI_API_KEY ({CliRuntime.MaskSecret(fromEnv)})").ConfigureAwait(false);
                return;
            }

            var fromSecrets = await CliRuntime.ReadUserSecretAsync("OPENAI_API_KEY", cancellationToken).ConfigureAwait(false);
            if (!string.IsNullOrWhiteSpace(fromSecrets))
            {
                await Console.Out.WriteLineAsync($"source: user-secrets ({CliRuntime.MaskSecret(fromSecrets)}) at {CliRuntime.GetUserSecretsPath()}").ConfigureAwait(false);
                return;
            }

            await Console.Out.WriteLineAsync("source: none — run `tryagi-openai auth set <key>` or set $OPENAI_API_KEY.").ConfigureAwait(false);
        }));
        return cmd;
    }

    private static Command CreateClearCommand()
    {
        var cmd = new Command("clear", "Remove the API key from user-secrets.");
        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            _ = parseResult;
            var cleared = await CliRuntime.ClearUserSecretAsync("OPENAI_API_KEY", cancellationToken).ConfigureAwait(false);
            await Console.Out.WriteLineAsync(cleared
                ? "Cleared stored OpenAI API key."
                : "No stored OpenAI API key to clear.").ConfigureAwait(false);
        }));
        return cmd;
    }
}
