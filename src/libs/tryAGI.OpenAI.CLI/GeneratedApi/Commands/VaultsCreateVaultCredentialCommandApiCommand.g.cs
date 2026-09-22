#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VaultsCreateVaultCredentialCommandApiCommand
{
    private static Argument<string> VaultId { get; } = new(
        name: @"vault-id")
    {
        Description = @"The ID of the vault.",
    };

    private static Option<string> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"The name is trimmed before storage. It must contain 1 to 256 UTF-8 bytes after trimming.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.CreateVaultCredentialAuthParam> Auth { get; } = new(
        name: @"--auth")
    {
        Description = @"The authentication method and write-only secret values to store.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VaultCredentialResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VaultCredentialResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-vault-credential", @"Create a vault credential
Creates a vault credential. Secret values are write-only and are never returned. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).");
                        command.Arguments.Add(VaultId);
                        command.Options.Add(NameOption);
                        command.Options.Add(Auth);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var vaultId = parseResult.GetRequiredValue(VaultId);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var auth = parseResult.GetRequiredValue(Auth);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Vaults.CreateVaultCredentialAsync(
                                    vaultId: vaultId,
                                    name: name,
                                    auth: auth,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}