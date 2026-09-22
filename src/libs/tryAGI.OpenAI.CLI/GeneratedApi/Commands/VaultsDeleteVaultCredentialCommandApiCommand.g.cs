#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VaultsDeleteVaultCredentialCommandApiCommand
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.DeletedVaultCredentialResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.DeletedVaultCredentialResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-vault-credential", @"Delete a vault credential
Deletes a vault credential. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).");
                        command.Arguments.Add(VaultId);
                        command.Arguments.Add(CredentialId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var vaultId = parseResult.GetRequiredValue(VaultId);
                        var credentialId = parseResult.GetRequiredValue(CredentialId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Vaults.DeleteVaultCredentialAsync(
                                    vaultId: vaultId,
                                    credentialId: credentialId,
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