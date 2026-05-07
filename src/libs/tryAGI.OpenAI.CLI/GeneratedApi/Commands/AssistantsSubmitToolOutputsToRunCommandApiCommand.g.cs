#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AssistantsSubmitToolOutputsToRunCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"The ID of the [thread](/docs/api-reference/threads) to which this run belongs.",
    };

    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"The ID of the run that requires the tool output submission.",
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
        var command = new Command(@"submit-tool-outputs-to-run", @"When a run has the `status: ""requires_action""` and `required_action.type` is `submit_tool_outputs`, this endpoint can be used to submit the outputs from the tool calls once they're all completed. All outputs must be submitted in a single request.
");
                        command.Arguments.Add(ThreadId);
                        command.Arguments.Add(RunId);
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
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                        var runId = parseResult.GetRequiredValue(RunId);
                        var request = await CliRuntime.ReadRequestAsync<global::tryAGI.OpenAI.SubmitToolOutputsRunRequest>(
                            parseResult,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Assistants.SubmitToolOutputsToRunAsync(
                                    threadId: threadId,
                                    runId: runId,
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