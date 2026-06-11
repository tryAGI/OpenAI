#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class CompactAResponseCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.ModelIdsCompaction> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Model ID used to generate the response, like `gpt-5` or `o3`. OpenAI offers a wide range of models with different capabilities, performance characteristics, and price points. Refer to the [model guide](/docs/models) to browse and compare available models.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>?> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"",
    };

    private static Option<string?> PreviousResponseId { get; } = new(
        name: @"--previous-response-id")
    {
        Description = @"",
    };

    private static Option<string?> Instructions { get; } = new(
        name: @"--instructions")
    {
        Description = @"",
    };

    private static Option<string?> PromptCacheKey { get; } = new(
        name: @"--prompt-cache-key")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.PromptCacheRetentionEnum?> PromptCacheRetention { get; } = new(
        name: @"--prompt-cache-retention")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.ServiceTierEnum2?> ServiceTier { get; } = new(
        name: @"--service-tier")
    {
        Description = @"",
    };
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.CompactResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.CompactResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"compact-aresponse", @"Compact a conversation. Returns a compacted response object.

Learn when and how to compact long-running conversations in the [conversation state guide](/docs/guides/conversation-state#managing-the-context-window). For ZDR-compatible compaction details, see [Compaction (advanced)](/docs/guides/conversation-state#compaction-advanced).");
                        command.Options.Add(Model);
                        command.Options.Add(InputOption);
                        command.Options.Add(PreviousResponseId);
                        command.Options.Add(Instructions);
                        command.Options.Add(PromptCacheKey);
                        command.Options.Add(PromptCacheRetention);
                        command.Options.Add(ServiceTier);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CompactResponseMethodPublicBody>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var input = CliRuntime.WasSpecified(parseResult, InputOption) ? parseResult.GetValue(InputOption) : __requestBase is not null ? __requestBase.Input : default;
                        var previousResponseId = CliRuntime.WasSpecified(parseResult, PreviousResponseId) ? parseResult.GetValue(PreviousResponseId) : __requestBase is not null ? __requestBase.PreviousResponseId : default;
                        var instructions = CliRuntime.WasSpecified(parseResult, Instructions) ? parseResult.GetValue(Instructions) : __requestBase is not null ? __requestBase.Instructions : default;
                        var promptCacheKey = CliRuntime.WasSpecified(parseResult, PromptCacheKey) ? parseResult.GetValue(PromptCacheKey) : __requestBase is not null ? __requestBase.PromptCacheKey : default;
                        var promptCacheRetention = CliRuntime.WasSpecified(parseResult, PromptCacheRetention) ? parseResult.GetValue(PromptCacheRetention) : __requestBase is not null ? __requestBase.PromptCacheRetention : default;
                        var serviceTier = CliRuntime.WasSpecified(parseResult, ServiceTier) ? parseResult.GetValue(ServiceTier) : __requestBase is not null ? __requestBase.ServiceTier : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CompactAResponseAsync(
                                    model: model,
                                    input: input,
                                    previousResponseId: previousResponseId,
                                    instructions: instructions,
                                    promptCacheKey: promptCacheKey,
                                    promptCacheRetention: promptCacheRetention,
                                    serviceTier: serviceTier,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Output",
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