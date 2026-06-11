#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ConversationsCreateItemsCommandApiCommand
{
    private static Argument<string> ConversationId { get; } = new(
        name: @"conversation-id")
    {
        Description = @"The ID of the conversation to add the item to.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"Additional fields to include in the response. See the `include`
parameter for [listing Conversation items above](/docs/api-reference/conversations/list-items#conversations_list_items-include) for more information.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>> Items { get; } = new(
        name: @"--items")
    {
        Description = @"The items to add to the conversation. You may add up to 20 items at a time.
",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ConversationItemList value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ConversationItemList value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-items", @"Create items in a conversation with the given ID.");
                        command.Arguments.Add(ConversationId);
                        command.Options.Add(Include);
                        command.Options.Add(Items);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var conversationId = parseResult.GetRequiredValue(ConversationId);
                        var include = parseResult.GetValue(Include);
                        var items = parseResult.GetRequiredValue(Items);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Conversations.CreateItemsAsync(
                                    conversationId: conversationId,
                                    include: include,
                                    items: items,
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