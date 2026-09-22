#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AgentsCreateAgentCommandApiCommand
{
    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters. Omission or null defaults to an empty map.",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"A human-readable name for the agent. Omission or null leaves the agent unnamed.",
    };

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use for the agent. The requested model name is preserved.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.ReasoningParam?> Reasoning { get; } = new(
        name: @"--reasoning")
    {
        Description = @"Configuration for model reasoning. Omission uses the model's default effort.",
    };

    private static Option<global::tryAGI.OpenAI.TextParam?> Text { get; } = new(
        name: @"--text")
    {
        Description = @"Configuration for generated text. Defaults to the `text` format and medium verbosity.",
    };

    private static Option<global::tryAGI.OpenAI.ServiceTierParam?> ServiceTier { get; } = new(
        name: @"--service-tier")
    {
        Description = @"The service tier used for model requests. Defaults to `auto`.",
    };

    private static Option<string?> Instructions { get; } = new(
        name: @"--instructions")
    {
        Description = @"Additional instructions appended to the agent's default base instructions. Omit or set to null to add no custom instructions.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"Tools available to the agent. Defaults to an empty list.",
    };
    private static readonly MultiAgentConfigCurrentParamOptionSet MultiAgentOptions = MultiAgentConfigCurrentParamOptionSet.Create(@"multi-agent");
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.AgentResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.AgentResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-agent", @"Create an agent
Creates a reusable agent without storing credentials. See [agent configuration](https://developers.openai.com/api/docs/guides/agents-api/configuration).");
                        command.Options.Add(Metadata);
                        command.Options.Add(NameOption);
                        command.Options.Add(Model);
                        command.Options.Add(Reasoning);
                        command.Options.Add(Text);
                        command.Options.Add(ServiceTier);
                        command.Options.Add(Instructions);
                        command.Options.Add(Tools);                        command.Options.Add(MultiAgentOptions.Enabled);
                        command.Options.Add(MultiAgentOptions.MaxConcurrentSubagents);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateAgentParams>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var model = parseResult.GetRequiredValue(Model);
                        var reasoning = CliRuntime.WasSpecified(parseResult, Reasoning) ? parseResult.GetValue(Reasoning) : (__requestBase is { } __ReasoningBaseValue ? __ReasoningBaseValue.Reasoning : default);
                        var text = CliRuntime.WasSpecified(parseResult, Text) ? parseResult.GetValue(Text) : (__requestBase is { } __TextBaseValue ? __TextBaseValue.Text : default);
                        var serviceTier = CliRuntime.WasSpecified(parseResult, ServiceTier) ? parseResult.GetValue(ServiceTier) : (__requestBase is { } __ServiceTierBaseValue ? __ServiceTierBaseValue.ServiceTier : default);
                        var instructions = CliRuntime.WasSpecified(parseResult, Instructions) ? parseResult.GetValue(Instructions) : (__requestBase is { } __InstructionsBaseValue ? __InstructionsBaseValue.Instructions : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);

                        var __MultiAgentBase = __requestBase is { } __MultiAgentBaseValue ? __MultiAgentBaseValue.MultiAgent : default;                        var multiAgentEnabled = parseResult.GetValue(MultiAgentOptions.Enabled);
                        var multiAgentMaxConcurrentSubagents = CliRuntime.WasSpecified(parseResult, MultiAgentOptions.MaxConcurrentSubagents) ? parseResult.GetValue(MultiAgentOptions.MaxConcurrentSubagents) : (__MultiAgentBase is { } __MultiAgentmaxConcurrentSubagentsBaseValue ? __MultiAgentmaxConcurrentSubagentsBaseValue.MaxConcurrentSubagents : default);
                        var __MultiAgentSpecified = CliRuntime.WasSpecified(parseResult, MultiAgentOptions.Enabled) || CliRuntime.WasSpecified(parseResult, MultiAgentOptions.MaxConcurrentSubagents);
                        var multiAgent =
                            __MultiAgentSpecified || __MultiAgentBase is not null
                                ? new global::tryAGI.OpenAI.MultiAgentConfigCurrentParam
                                {
	                                Enabled = multiAgentEnabled!,
                                MaxConcurrentSubagents = multiAgentMaxConcurrentSubagents,

                                }
                                : __MultiAgentBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.CreateAgentAsync(
                                    metadata: metadata,
                                    name: name,
                                    model: model,
                                    reasoning: reasoning,
                                    text: text,
                                    serviceTier: serviceTier,
                                    instructions: instructions,
                                    tools: tools,
                                    multiAgent: multiAgent,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Tools",
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