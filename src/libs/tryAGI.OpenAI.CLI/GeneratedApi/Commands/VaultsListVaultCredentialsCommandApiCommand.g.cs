#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VaultsListVaultCredentialsCommandApiCommand
{
    private static Argument<string> VaultId { get; } = new(
        name: @"vault-id")
    {
        Description = @"The ID of the vault.",
    };

    private static Option<global::tryAGI.OpenAI.ListOrderParam?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order by the `created_at` timestamp. Use `asc` for ascending order or `desc` for descending order. Defaults to `desc`.",
    };

    private static Option<long?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"The maximum number of resources to return. Defaults to 20. Values are clamped between 1 and 100.",
    };

    private static Option<global::tryAGI.OpenAI.VaultStatusFilterParam?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter by one status or a list, such as `status=active` or `status[]=active&status[]=archived`. Both statuses are included by default.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Return resources after this resource ID in the selected order.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VaultCredentialListResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VaultCredentialListResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-vault-credentials", @"List vault credentials
Lists a vault's credentials using ID-based pagination without returning secret values. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).");
                        command.Arguments.Add(VaultId);
                        command.Options.Add(Order);
                        command.Options.Add(Limit);
                        command.Options.Add(Status);
                        command.Options.Add(After);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var vaultId = parseResult.GetRequiredValue(VaultId);
                        var order = parseResult.GetValue(Order);
                        var limit = parseResult.GetValue(Limit);
                        var status = parseResult.GetValue(Status);
                        var after = parseResult.GetValue(After);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Vaults.ListVaultCredentialsAsync(
                                    vaultId: vaultId,
                                    order: order,
                                    limit: limit,
                                    status: status,
                                    after: after,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}