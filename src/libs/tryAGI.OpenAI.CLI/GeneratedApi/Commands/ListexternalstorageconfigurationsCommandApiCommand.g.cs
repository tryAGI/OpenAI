#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ListexternalstorageconfigurationsCommandApiCommand
{
    private static Option<string?> ProjectId { get; } = new(
        name: @"--project-id")
    {
        Description = @"",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Return external storage configurations after this ID.",
    };

    private static Option<global::tryAGI.OpenAI.ExternalStorageOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ExternalStorageListResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ExternalStorageListResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"listexternalstorageconfigurations", @"List external storage configurations
List the organization's customer-managed external storage configurations.");
                        command.Options.Add(ProjectId);
                        command.Options.Add(After);
                        command.Options.Add(Order);
                        command.Options.Add(Limit);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetValue(ProjectId);
                        var after = parseResult.GetValue(After);
                        var order = parseResult.GetValue(Order);
                        var limit = parseResult.GetValue(Limit);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ListexternalstorageconfigurationsAsync(
                                    projectId: projectId,
                                    after: after,
                                    order: order,
                                    limit: limit,
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