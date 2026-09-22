#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AgentsListAgentEnvironmentFilesCommandApiCommand
{
    private static Argument<string> EnvironmentId { get; } = new(
        name: @"environment-id")
    {
        Description = @"The ID of the environment.",
    };

    private static Option<string?> Path { get; } = new(
        name: @"--path")
    {
        Description = @"Restrict the listing to this absolute workspace directory.",
    };

    private static Option<long?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"The maximum number of files to return, between 1 and 100.",
    };

    private static Option<global::tryAGI.OpenAI.ListOrderParam?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort by case-sensitive path components. Defaults to descending.",
    };

    private static Option<string?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"The opaque token from the previous page. Keep the same path, order, and limit.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.EnvironmentFileListResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.EnvironmentFileListResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-agent-environment-files", @"List agent environment files
Lists live files on a connected execution environment with optional directory filtering and opaque cursor pagination. See [environment files](https://developers.openai.com/api/docs/guides/agents-api/environments/files).");
                        command.Arguments.Add(EnvironmentId);
                        command.Options.Add(Path);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(Page);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var environmentId = parseResult.GetRequiredValue(EnvironmentId);
                        var path = parseResult.GetValue(Path);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var page = parseResult.GetValue(Page);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.ListAgentEnvironmentFilesAsync(
                                    environmentId: environmentId,
                                    path: path,
                                    limit: limit,
                                    order: order,
                                    page: page,
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