#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ChatUpdateChatCompletionCommandApiCommand
{
    private static Argument<string> CompletionId { get; } = new(
        name: @"completion-id")
    {
        Description = @"The ID of the chat completion to update.",
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
        var command = new Command(@"update-chat-completion", @"Modify a stored chat completion. Only Chat Completions that have been
created with the `store` parameter set to `true` can be modified. Currently,
the only supported modification is to update the `metadata` field.
");
                        command.Arguments.Add(CompletionId);
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
                        var completionId = parseResult.GetRequiredValue(CompletionId);
                        var request = await CliRuntime.ReadRequestAsync<global::tryAGI.OpenAI.UpdateChatCompletionRequest>(
                            parseResult,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Chat.UpdateChatCompletionAsync(
                                    completionId: completionId,
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