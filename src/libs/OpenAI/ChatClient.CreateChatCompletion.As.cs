// ReSharper disable RedundantNameQualifier

using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;

namespace OpenAI
{
    public partial class ChatClient
    {
        /// <inheritdoc cref="CreateChatCompletionAsync(System.Collections.Generic.IList{ChatCompletionRequestMessage},System.AnyOf{string?,CreateChatCompletionRequestModel?},double?,CreateChatCompletionRequestLogitBias?,bool?,int?,int?,int?,double?,System.OneOf{ResponseFormatText,ResponseFormatJsonObject,ResponseFormatJsonSchema}?,int?,CreateChatCompletionRequestServiceTier?,System.OneOf{string?,System.Collections.Generic.IList{string}}?,bool?,ChatCompletionStreamOptions?,double?,double?,System.Collections.Generic.IList{ChatCompletionTool}?,ChatCompletionToolChoiceOption?,bool?,string?,System.Threading.CancellationToken)"/>
#if NET6_0_OR_GREATER
        [RequiresUnreferencedCode(
            "This method uses reflection to generate a JSON schema. Use overload with JsonTypeInfo parameter to avoid this.")]
#endif
#if NET8_0_OR_GREATER
        [RequiresDynamicCode("This method uses reflection to generate a JSON schema. Use overload with JsonTypeInfo parameter to avoid this.")]
#endif
        public async global::System.Threading.Tasks.Task<System.AnyOf<T, global::OpenAI.CreateChatCompletionResponse>>
            CreateChatCompletionAsAsync<T>(
                global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessage> messages,
                global::System.AnyOf<string, global::OpenAI.CreateChatCompletionRequestModel?> model,
                double? frequencyPenalty = 0,
                global::OpenAI.CreateChatCompletionRequestLogitBias? logitBias = default,
                bool? logprobs = false,
                int? topLogprobs = default,
                int? maxTokens = default,
                int? n = 1,
                double? presencePenalty = 0,
                int? seed = default,
                global::OpenAI.CreateChatCompletionRequestServiceTier? serviceTier = default,
                global::System.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
                bool? stream = false,
                bool? strict = true,
                global::OpenAI.ChatCompletionStreamOptions? streamOptions = default,
                double? temperature = 1,
                double? topP = 1,
                global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool>? tools = default,
                global::OpenAI.ChatCompletionToolChoiceOption? toolChoice = default,
                bool? parallelToolCalls = default,
                string? user = default,
                JsonSerializerOptions? jsonSerializerOptions = null,
                global::System.Threading.CancellationToken cancellationToken = default)
            where T : class, new() // T should be json object
        {
            var request = new global::OpenAI.CreateChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Logprobs = logprobs,
                TopLogprobs = topLogprobs,
                MaxTokens = maxTokens,
                N = n,
                PresencePenalty = presencePenalty,
                ResponseFormat = new ResponseFormatJsonSchema
                {
                    Type = ResponseFormatJsonSchemaType.JsonSchema,
                    JsonSchema = TypeToSchemaHelpers.AsResponseFormat(typeof(T), strict ?? false),
                },
                Seed = seed,
                ServiceTier = serviceTier,
                Stop = stop,
                Stream = stream,
                StreamOptions = streamOptions,
                Temperature = temperature,
                TopP = topP,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                User = user,
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

        /// <inheritdoc cref="CreateChatCompletionAsync(System.Collections.Generic.IList{ChatCompletionRequestMessage},System.AnyOf{string?,CreateChatCompletionRequestModel?},double?,CreateChatCompletionRequestLogitBias?,bool?,int?,int?,int?,double?,System.OneOf{ResponseFormatText,ResponseFormatJsonObject,ResponseFormatJsonSchema}?,int?,CreateChatCompletionRequestServiceTier?,System.OneOf{string?,System.Collections.Generic.IList{string}}?,bool?,ChatCompletionStreamOptions?,double?,double?,System.Collections.Generic.IList{ChatCompletionTool}?,ChatCompletionToolChoiceOption?,bool?,string?,System.Threading.CancellationToken)"/>
        public async global::System.Threading.Tasks.Task<System.AnyOf<T, global::OpenAI.CreateChatCompletionResponse>>
            CreateChatCompletionAsAsync<T>(
                JsonTypeInfo<T> jsonTypeInfo,
                global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessage> messages,
                global::System.AnyOf<string, global::OpenAI.CreateChatCompletionRequestModel?> model,
                double? frequencyPenalty = 0,
                global::OpenAI.CreateChatCompletionRequestLogitBias? logitBias = default,
                bool? logprobs = false,
                int? topLogprobs = default,
                int? maxTokens = default,
                int? n = 1,
                double? presencePenalty = 0,
                int? seed = default,
                global::OpenAI.CreateChatCompletionRequestServiceTier? serviceTier = default,
                global::System.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
                bool? stream = false,
                bool? strict = true,
                global::OpenAI.ChatCompletionStreamOptions? streamOptions = default,
                double? temperature = 1,
                double? topP = 1,
                global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool>? tools = default,
                global::OpenAI.ChatCompletionToolChoiceOption? toolChoice = default,
                bool? parallelToolCalls = default,
                string? user = default,
                global::System.Threading.CancellationToken cancellationToken = default)
            where T : class, new() // T should be json object
        {
            var request = new global::OpenAI.CreateChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Logprobs = logprobs,
                TopLogprobs = topLogprobs,
                MaxTokens = maxTokens,
                N = n,
                PresencePenalty = presencePenalty,
                ResponseFormat = new ResponseFormatJsonSchema
                {
                    Type = ResponseFormatJsonSchemaType.JsonSchema,
                    JsonSchema = TypeToSchemaHelpers.AsResponseFormat(jsonTypeInfo, strict ?? false),
                },
                Seed = seed,
                ServiceTier = serviceTier,
                Stop = stop,
                Stream = stream,
                StreamOptions = streamOptions,
                Temperature = temperature,
                TopP = topP,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                User = user,
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
