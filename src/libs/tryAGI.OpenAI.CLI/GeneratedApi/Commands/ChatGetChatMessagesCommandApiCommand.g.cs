#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ChatGetChatMessagesCommandApiCommand
{
    private static Argument<string> CompletionId { get; } = new(
        name: @"completion-id")
    {
        Description = @"The ID of the chat completion to retrieve messages from.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Identifier for the last message from the previous pagination request.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of messages to retrieve.",
    };

    private static Option<global::tryAGI.OpenAI.GetChatCompletionMessagesOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for messages by timestamp. Use `asc` for ascending order or `desc` for descending order. Defaults to `asc`.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ChatCompletionMessageList value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ChatCompletionMessageList value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-chat-messages", @"Get the messages in a stored chat completion. Only Chat Completions that
have been created with the `store` parameter set to `true` will be
returned.
");
                        command.Arguments.Add(CompletionId);
                        command.Options.Add(After);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var completionId = parseResult.GetRequiredValue(CompletionId);
                        var after = parseResult.GetValue(After);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Chat.GetChatMessagesAsync(
                                    completionId: completionId,
                                    after: after,
                                    limit: limit,
                                    order: order,
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