#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AssistantsCreateRunCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"The ID of the thread to run.",
    };    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"A list of additional fields to include in the response. Currently the only supported value is `step_details.tool_calls[*].file_search.results[*].content` to fetch the file search result content.

See the [file search tool documentation](/docs/assistants/tools/file-search#customizing-file-search-settings) for more information.
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
        var command = new Command(@"create-run", @"Create a run.");
                        command.Arguments.Add(ThreadId);
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
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                        var include = parseResult.GetValue(Include);
                        var request = await CliRuntime.ReadRequestAsync<global::tryAGI.OpenAI.CreateRunRequest>(
                            parseResult,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Assistants.CreateRunAsync(
                                    threadId: threadId,
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