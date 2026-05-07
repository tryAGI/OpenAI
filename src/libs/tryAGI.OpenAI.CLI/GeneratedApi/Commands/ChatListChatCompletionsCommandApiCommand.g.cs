#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ChatListChatCompletionsCommandApiCommand
{
     private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model used to generate the Chat Completions.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"A list of metadata keys to filter the Chat Completions by. Example:

`metadata[key1]=value1&metadata[key2]=value2`
",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Identifier for the last chat completion from the previous pagination request.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of Chat Completions to retrieve.",
    };

    private static Option<global::tryAGI.OpenAI.ListChatCompletionsOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for Chat Completions by timestamp. Use `asc` for ascending order or `desc` for descending order. Defaults to `asc`.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-chat-completions", @"List stored Chat Completions. Only Chat Completions that have been stored
with the `store` parameter set to `true` will be returned.
");
                        command.Options.Add(Model);
                        command.Options.Add(Metadata);
                        command.Options.Add(After);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var model = parseResult.GetValue(Model);
                        var metadata = parseResult.GetValue(Metadata);
                        var after = parseResult.GetValue(After);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Chat.ListChatCompletionsAsync(
                                    model: model,
                                    metadata: metadata,
                                    after: after,
                                    limit: limit,
                                    order: order,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteJsonAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}