#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AssistantsCreateThreadCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>?> Messages { get; } = new(
        name: @"--messages")
    {
        Description = @"A list of [messages](/docs/api-reference/messages) to start the thread with.",
    };

    private static Option<global::tryAGI.OpenAI.CreateThreadRequestToolResources2?> ToolResources { get; } = new(
        name: @"--tool-resources")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ThreadObject value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ThreadObject value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-thread", @"Create a thread.");
                        command.Options.Add(Messages);
                        command.Options.Add(ToolResources);
                        command.Options.Add(Metadata);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateThreadRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var messages = CliRuntime.WasSpecified(parseResult, Messages) ? parseResult.GetValue(Messages) : __requestBase is not null ? __requestBase.Messages : default;
                        var toolResources = CliRuntime.WasSpecified(parseResult, ToolResources) ? parseResult.GetValue(ToolResources) : __requestBase is not null ? __requestBase.ToolResources : default;
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : __requestBase is not null ? __requestBase.Metadata : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Assistants.CreateThreadAsync(
                                    messages: messages,
                                    toolResources: toolResources,
                                    metadata: metadata,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}