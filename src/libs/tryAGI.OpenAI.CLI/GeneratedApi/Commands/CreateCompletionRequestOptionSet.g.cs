#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateCompletionRequestOptionSet(
    Option<int?> BestOf,
                     Option<bool?> Echo,
                     Option<double?> FrequencyPenalty,
                     Option<int?> Logprobs,
                     Option<int?> MaxTokens,
                     Option<int?> N,
                     Option<double?> PresencePenalty,
                     Option<long?> Seed,
                     Option<bool?> Stream,
                     Option<string?> Suffix,
                     Option<double?> Temperature,
                     Option<double?> TopP,
                     Option<string?> User)
{
    public static CreateCompletionRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateCompletionRequestOptionSet(
                        BestOf: new Option<int?>($"--{normalizedPrefix}best-of")
                {
                    Description = @"Generates `best_of` completions server-side and returns the ""best"" (the one with the highest log probability per token). Results cannot be streamed.

When used with `n`, `best_of` controls the number of candidate completions and `n` specifies how many to return – `best_of` must be greater than `n`.

**Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.
",
                },
                Echo: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}echo", description: @"Echo back the prompt in addition to the completion
"),
                FrequencyPenalty: new Option<double?>($"--{normalizedPrefix}frequency-penalty")
                {
                    Description = @"Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.

[See more information about frequency and presence penalties.](https://developers.openai.com/api/docs/guides/text)
",
                },
                Logprobs: new Option<int?>($"--{normalizedPrefix}logprobs")
                {
                    Description = @"Include the log probabilities on the `logprobs` most likely output tokens, as well the chosen tokens. For example, if `logprobs` is 5, the API will return a list of the 5 most likely tokens. The API will always return the `logprob` of the sampled token, so there may be up to `logprobs+1` elements in the response.

The maximum value for `logprobs` is 5.
",
                },
                MaxTokens: new Option<int?>($"--{normalizedPrefix}max-tokens")
                {
                    Description = @"The maximum number of [tokens](https://platform.openai.com/tokenizer) that can be generated in the completion.

The token count of your prompt plus `max_tokens` cannot exceed the model's context length. [Example Python code](https://cookbook.openai.com/examples/how_to_count_tokens_with_tiktoken) for counting tokens.
",
                },
                N: new Option<int?>($"--{normalizedPrefix}n")
                {
                    Description = @"How many completions to generate for each prompt.

**Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.
",
                },
                PresencePenalty: new Option<double?>($"--{normalizedPrefix}presence-penalty")
                {
                    Description = @"Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.

[See more information about frequency and presence penalties.](https://developers.openai.com/api/docs/guides/text)
",
                },
                Seed: new Option<long?>($"--{normalizedPrefix}seed")
                {
                    Description = @"If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.

Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
",
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"Whether to stream back partial progress. If set, tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).
"),
                Suffix: new Option<string?>($"--{normalizedPrefix}suffix")
                {
                    Description = @"The suffix that comes after a completion of inserted text.

This parameter is only supported for `gpt-3.5-turbo-instruct`.
",
                },
                Temperature: new Option<double?>($"--{normalizedPrefix}temperature")
                {
                    Description = @"What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.

We generally recommend altering this or `top_p` but not both.
",
                },
                TopP: new Option<double?>($"--{normalizedPrefix}top-p")
                {
                    Description = @"An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.

We generally recommend altering this or `temperature` but not both.
",
                },
                User: new Option<string?>($"--{normalizedPrefix}user")
                {
                    Description = @"A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](https://developers.openai.com/api/docs/guides/safety-best-practices#implement-safety-identifiers).
",
                }
        );
    }
}