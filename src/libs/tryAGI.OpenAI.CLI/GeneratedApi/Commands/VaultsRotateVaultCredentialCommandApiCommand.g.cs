#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VaultsRotateVaultCredentialCommandApiCommand
{
    private static Argument<string> VaultId { get; } = new(
        name: @"vault-id")
    {
        Description = @"The ID of the vault.",
    };

    private static Argument<string> CredentialId { get; } = new(
        name: @"credential-id")
    {
        Description = @"The ID of the vault credential.",
    };

    private static Option<global::tryAGI.OpenAI.RotateVaultCredentialAuthParam> Auth { get; } = new(
        name: @"--auth")
    {
        Description = @"Replacement values for the credential's existing authentication method.",
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
        var command = new Command(@"rotate-vault-credential", @"Rotate a vault credential
Rotates a vault credential's write-only secret and returns only credential metadata. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).");
                        command.Arguments.Add(VaultId);
                        command.Arguments.Add(CredentialId);
                        command.Options.Add(Auth);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var vaultId = parseResult.GetRequiredValue(VaultId);
                        var credentialId = parseResult.GetRequiredValue(CredentialId);
                        var auth = parseResult.GetRequiredValue(Auth);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Vaults.RotateVaultCredentialAsync(
                                    vaultId: vaultId,
                                    credentialId: credentialId,
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