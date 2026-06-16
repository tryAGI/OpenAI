#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AssistantsModifyMessageCommandApiCommand
{
    private static Argument<string> ThreadId { get; } = new(
        name: @"thread-id")
    {
        Description = @"The ID of the thread to which this message belongs.",
    };

    private static Argument<string> MessageId { get; } = new(
        name: @"message-id")
    {
        Description = @"The ID of the message to modify.",
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.MessageObject value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.MessageObject value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"modify-message", @"Modifies a message.");
                        command.Arguments.Add(ThreadId);
                        command.Arguments.Add(MessageId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.ModifyMessageRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var threadId = parseResult.GetRequiredValue(ThreadId);
                        var messageId = parseResult.GetRequiredValue(MessageId);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Assistants.ModifyMessageAsync(
                                    threadId: threadId,
                                    messageId: messageId,
                                    metadata: metadata,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Content",
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