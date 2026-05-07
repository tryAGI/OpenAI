#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ConversationsCreateItemsCommandApiCommand
{
    private static Argument<string> ConversationId { get; } = new(
        name: @"conversation-id")
    {
        Description = @"The ID of the conversation to add the item to.",
    };    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"Additional fields to include in the response. See the `include`
parameter for [listing Conversation items above](/docs/api-reference/conversations/list-items#conversations_list_items-include) for more information.
",
    };
      private static Option<string?> RequestJson { get; } = new("--request-json")
      {
          Description = "Request body as JSON.",
      };

      private static Option<string?> RequestFile { get; } = new("--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
      };

    public static Command Create()
    {
        var command = new Command(@"create-items", @"Create items in a conversation with the given ID.");
                        command.Arguments.Add(ConversationId);
                        command.Options.Add(Include);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              if (hasRequestJson == hasRequestFile)
              {
                  result.AddError("Specify exactly one of --request-json or --request-file.");
              }
          });
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var conversationId = parseResult.GetRequiredValue(ConversationId);
                        var include = parseResult.GetValue(Include);
                        var request = await CliRuntime.ReadRequestAsync<global::tryAGI.OpenAI.CreateConversationItemsRequest>(
                            parseResult,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Conversations.CreateItemsAsync(
                                    conversationId: conversationId,
                                    include: include,
                                    request: request,
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