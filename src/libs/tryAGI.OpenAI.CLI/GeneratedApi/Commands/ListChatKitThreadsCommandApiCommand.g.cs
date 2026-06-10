#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ListChatKitThreadsCommandApiCommand
{
    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of thread items to return. Defaults to 20.",
    };

    private static Option<global::tryAGI.OpenAI.OrderEnum?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for results by creation time. Defaults to `desc`.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"List items created after this thread item ID. Defaults to null for the first page.",
    };

    private static Option<string?> Before { get; } = new(
        name: @"--before")
    {
        Description = @"List items created before this thread item ID. Defaults to null for the newest results.",
    };

    private static Option<string?> User { get; } = new(
        name: @"--user")
    {
        Description = @"Filter threads that belong to this user identifier. Defaults to null to return all users.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ThreadListResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ThreadListResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-chat-kit-threads", @"List ChatKit threads with optional pagination and user filters.");
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);
                        command.Options.Add(Before);
                        command.Options.Add(User);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                        var before = parseResult.GetValue(Before);
                        var user = parseResult.GetValue(User);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ListChatKitThreadsAsync(
                                    limit: limit,
                                    order: order,
                                    after: after,
                                    before: before,
                                    user: user,
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