// ReSharper disable RedundantNameQualifier

using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;

namespace OpenAI
{
    public partial class ChatClient
    {
        /// <inheritdoc cref="CreateChatCompletionAsync(System.Collections.Generic.IList{ChatCompletionRequestMessage},OpenAI.AnyOf{string?,CreateChatCompletionRequestModel?},bool?,System.Collections.Generic.Dictionary{string, string}?,double?,global::System.Collections.Generic.Dictionary{string, int}?,bool?,int?,int?,int?,System.Collections.Generic.IList{global::OpenAI.ChatCompletionModalitie}?,CreateChatCompletionRequestAudio?,double?,OpenAI.ResponseFormat?,int?,CreateChatCompletionRequestServiceTier?,OpenAI.OneOf{string?,System.Collections.Generic.IList{string}}?,bool?,ChatCompletionStreamOptions?,double?,double?,System.Collections.Generic.IList{ChatCompletionTool}?,ChatCompletionToolChoiceOption?,bool?,string?,System.Threading.CancellationToken)"/>
#if NET6_0_OR_GREATER
        [RequiresUnreferencedCode(
            "This method uses reflection to generate a JSON schema. Use overload with JsonTypeInfo parameter to avoid this.")]
#endif
#if NET8_0_OR_GREATER
        [RequiresDynamicCode("This method uses reflection to generate a JSON schema. Use overload with JsonTypeInfo parameter to avoid this.")]
#endif
        public async global::System.Threading.Tasks.Task<OpenAI.AnyOf<T, global::OpenAI.CreateChatCompletionResponse>>
            CreateChatCompletionAsAsync<T>(
                global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessage> messages,
                global::OpenAI.AnyOf<string, global::OpenAI.CreateChatCompletionRequestModel?> model,
                bool? store = default,
                global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
                double? frequencyPenalty = default,
                global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
                bool? logprobs = default,
                int? topLogprobs = default,
                int? maxCompletionTokens = default,
                int? n = default,
                global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionModalitie>? modalities = default,
                global::OpenAI.CreateChatCompletionRequestAudio? audio = default,
                double? presencePenalty = default,
                global::OpenAI.ResponseFormat? responseFormat = default,
                int? seed = default,
                global::OpenAI.CreateChatCompletionRequestServiceTier? serviceTier = default,
                global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
                bool? stream = default,
                global::OpenAI.ChatCompletionStreamOptions? streamOptions = default,
                double? temperature = default,
                double? topP = default,
                global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool>? tools = default,
                global::OpenAI.ChatCompletionToolChoiceOption? toolChoice = default,
                bool? parallelToolCalls = default,
                string? user = default,
                bool? strict = true,
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
                MaxCompletionTokens = maxCompletionTokens,
                N = n,
                PresencePenalty = presencePenalty,
                ResponseFormat = new ResponseFormatJsonSchema
                {
                    Type = ResponseFormatJsonSchemaType.JsonSchema,
                    JsonSchema = TypeToSchemaHelpers2.AsResponseFormat(typeof(T), strict ?? false),
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

        /// <inheritdoc cref="CreateChatCompletionAsync(System.Collections.Generic.IList{ChatCompletionRequestMessage},OpenAI.AnyOf{string?,CreateChatCompletionRequestModel?},bool?,System.Collections.Generic.Dictionary{string, string}?,double?,global::System.Collections.Generic.Dictionary{string, int}?,bool?,int?,int?,int?,System.Collections.Generic.IList{global::OpenAI.ChatCompletionModalitie}?,CreateChatCompletionRequestAudio?,double?,OpenAI.ResponseFormat?,int?,CreateChatCompletionRequestServiceTier?,OpenAI.OneOf{string?,System.Collections.Generic.IList{string}}?,bool?,ChatCompletionStreamOptions?,double?,double?,System.Collections.Generic.IList{ChatCompletionTool}?,ChatCompletionToolChoiceOption?,bool?,string?,System.Threading.CancellationToken)"/>
        public async global::System.Threading.Tasks.Task<OpenAI.AnyOf<T, global::OpenAI.CreateChatCompletionResponse>>
            CreateChatCompletionAsAsync<T>(
                JsonTypeInfo<T> jsonTypeInfo,
                global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessage> messages,
                global::OpenAI.AnyOf<string, global::OpenAI.CreateChatCompletionRequestModel?> model,
                bool? store = default,
                global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
                double? frequencyPenalty = default,
                global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
                bool? logprobs = default,
                int? topLogprobs = default,
                int? maxCompletionTokens = default,
                int? n = default,
                global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionModalitie>? modalities = default,
                global::OpenAI.CreateChatCompletionRequestAudio? audio = default,
                double? presencePenalty = default,
                global::OpenAI.ResponseFormat? responseFormat = default,
                int? seed = default,
                global::OpenAI.CreateChatCompletionRequestServiceTier? serviceTier = default,
                global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
                bool? stream = default,
                global::OpenAI.ChatCompletionStreamOptions? streamOptions = default,
                double? temperature = default,
                double? topP = default,
                global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool>? tools = default,
                global::OpenAI.ChatCompletionToolChoiceOption? toolChoice = default,
                bool? parallelToolCalls = default,
                string? user = default,
                bool? strict = true,
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
                MaxCompletionTokens = maxCompletionTokens,
                N = n,
                PresencePenalty = presencePenalty,
                ResponseFormat = new ResponseFormatJsonSchema
                {
                    Type = ResponseFormatJsonSchemaType.JsonSchema,
                    JsonSchema = TypeToSchemaHelpers2.AsResponseFormat(jsonTypeInfo, strict ?? false),
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
