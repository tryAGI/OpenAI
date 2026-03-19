// ReSharper disable RedundantNameQualifier

using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace tryAGI.OpenAI
{
    public partial class ChatClient
    {
        /// <summary>
        /// Creates a chat completion and deserializes the response into the specified type
        /// using reflection-based JSON schema generation.
        /// For AOT/trimming compatibility, use the overload that accepts a <see cref="JsonTypeInfo{T}"/> parameter.
        /// </summary>
#if NET6_0_OR_GREATER
        [RequiresUnreferencedCode(
            "This method uses reflection to generate a JSON schema. Use overload with JsonTypeInfo parameter to avoid this.")]
#endif
#if NET8_0_OR_GREATER
        [RequiresDynamicCode("This method uses reflection to generate a JSON schema. Use overload with JsonTypeInfo parameter to avoid this.")]
#endif
        public async global::System.Threading.Tasks.Task<AnyOf<T, global::tryAGI.OpenAI.CreateChatCompletionResponse>>
            CreateChatCompletionAsAsync<T>(
                global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage> messages,
                global::tryAGI.OpenAI.ModelIdsShared model,
                bool? store = default,
                double? frequencyPenalty = default,
                global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
                bool? logprobs = default,
                int? topLogprobs = default,
                int? maxCompletionTokens = default,
                int? n = default,
                double? presencePenalty = default,
                int? seed = default,
                global::tryAGI.OpenAI.StopConfiguration? stop = default,
                global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>? tools = default,
                global::tryAGI.OpenAI.ChatCompletionToolChoiceOption? toolChoice = default,
                bool? parallelToolCalls = default,
                bool? strict = true,
                JsonSerializerOptions? jsonSerializerOptions = null,
                global::System.Threading.CancellationToken cancellationToken = default)
            where T : class, new()
        {
            var request = new global::tryAGI.OpenAI.CreateChatCompletionRequest
            {
                Value2 = new global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2
                {
                    Messages = messages,
                    Model = model,
                    Store = store,
                    FrequencyPenalty = frequencyPenalty,
                    LogitBias = logitBias,
                    Logprobs = logprobs,
                    TopLogprobs = topLogprobs,
                    MaxCompletionTokens = maxCompletionTokens,
                    N = n,
                    PresencePenalty = presencePenalty,
                    ResponseFormat = new ResponseFormatJsonSchema
                    {
                        Type = ResponseFormatJsonSchemaType.JsonSchema,
                        JsonSchema = TypeToSchemaHelpers2.AsResponseFormat(typeof(T), strict ?? false),
                    },
#pragma warning disable CS0618 // Seed is deprecated but still functional
                    Seed = seed,
#pragma warning restore CS0618
                    Stop = stop,
                    Tools = tools,
                    ToolChoice = toolChoice,
                    ParallelToolCalls = parallelToolCalls,
                },
            };

            var response = await CreateChatCompletionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            return new AnyOf<T, CreateChatCompletionResponse>(
#pragma warning disable IL3050
                JsonSerializer.Deserialize<T>(response, options: jsonSerializerOptions),
#pragma warning restore IL3050
                response);
        }

        /// <summary>
        /// AOT-compatible overload using JsonTypeInfo.
        /// </summary>
        public async global::System.Threading.Tasks.Task<AnyOf<T, global::tryAGI.OpenAI.CreateChatCompletionResponse>>
            CreateChatCompletionAsAsync<T>(
                JsonTypeInfo<T> jsonTypeInfo,
                global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage> messages,
                global::tryAGI.OpenAI.ModelIdsShared model,
                bool? store = default,
                double? frequencyPenalty = default,
                global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
                bool? logprobs = default,
                int? topLogprobs = default,
                int? maxCompletionTokens = default,
                int? n = default,
                double? presencePenalty = default,
                int? seed = default,
                global::tryAGI.OpenAI.StopConfiguration? stop = default,
                global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ChatCompletionTool, global::tryAGI.OpenAI.CustomToolChatCompletions>>? tools = default,
                global::tryAGI.OpenAI.ChatCompletionToolChoiceOption? toolChoice = default,
                bool? parallelToolCalls = default,
                bool? strict = true,
                global::System.Threading.CancellationToken cancellationToken = default)
            where T : class, new()
        {
            var request = new global::tryAGI.OpenAI.CreateChatCompletionRequest
            {
                Value2 = new global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2
                {
                    Messages = messages,
                    Model = model,
                    Store = store,
                    FrequencyPenalty = frequencyPenalty,
                    LogitBias = logitBias,
                    Logprobs = logprobs,
                    TopLogprobs = topLogprobs,
                    MaxCompletionTokens = maxCompletionTokens,
                    N = n,
                    PresencePenalty = presencePenalty,
                    ResponseFormat = new ResponseFormatJsonSchema
                    {
                        Type = ResponseFormatJsonSchemaType.JsonSchema,
                        JsonSchema = TypeToSchemaHelpers2.AsResponseFormat(jsonTypeInfo, strict ?? false),
                    },
#pragma warning disable CS0618 // Seed is deprecated but still functional
                    Seed = seed,
#pragma warning restore CS0618
                    Stop = stop,
                    Tools = tools,
                    ToolChoice = toolChoice,
                    ParallelToolCalls = parallelToolCalls,
                },
            };

            var response = await CreateChatCompletionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            return new AnyOf<T, CreateChatCompletionResponse>(
                JsonSerializer.Deserialize(response, jsonTypeInfo),
                response);
        }
    }
}
