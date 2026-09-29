#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateRunRequestOptionSet(
    Option<string> AssistantId,
                     Option<string?> Instructions,
                     Option<string?> AdditionalInstructions,
                     Option<double?> Temperature,
                     Option<double?> TopP,
                     Option<bool?> Stream,
                     Option<int?> MaxPromptTokens,
                     Option<int?> MaxCompletionTokens,
                     Option<bool?> ParallelToolCalls)
{
    public static CreateRunRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateRunRequestOptionSet(
                        AssistantId: new Option<string>($"--{normalizedPrefix}assistant-id")
                {
                    Description = @"The ID of the [assistant](https://developers.openai.com/api/docs/assistants/migration) to use to execute this run.",
                    Required = true,
                },
                Instructions: new Option<string?>($"--{normalizedPrefix}instructions")
                {
                    Description = @"Overrides the [instructions](https://developers.openai.com/api/docs/assistants/migration) of the assistant. This is useful for modifying the behavior on a per-run basis.",
                },
                AdditionalInstructions: new Option<string?>($"--{normalizedPrefix}additional-instructions")
                {
                    Description = @"Appends additional instructions at the end of the instructions for the run. This is useful for modifying the behavior on a per-run basis without overriding other instructions.",
                },
                Temperature: new Option<double?>($"--{normalizedPrefix}temperature")
                {
                    Description = @"What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
",
                },
                TopP: new Option<double?>($"--{normalizedPrefix}top-p")
                {
                    Description = @"An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.

We generally recommend altering this or temperature but not both.
",
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"If `true`, returns a stream of events that happen during the Run as server-sent events, terminating when the Run enters a terminal state with a `data: [DONE]` message.
"),
                MaxPromptTokens: new Option<int?>($"--{normalizedPrefix}max-prompt-tokens")
                {
                    Description = @"The maximum number of prompt tokens that may be used over the course of the run. The run will make a best effort to use only the number of prompt tokens specified, across multiple turns of the run. If the run exceeds the number of prompt tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
",
                },
                MaxCompletionTokens: new Option<int?>($"--{normalizedPrefix}max-completion-tokens")
                {
                    Description = @"The maximum number of completion tokens that may be used over the course of the run. The run will make a best effort to use only the number of completion tokens specified, across multiple turns of the run. If the run exceeds the number of completion tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
",
                },
                ParallelToolCalls: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}parallel-tool-calls", description: @"Whether to enable [parallel function calling](https://developers.openai.com/api/docs/guides/function-calling#parallel-function-calling) during tool use.")
        );
    }
}