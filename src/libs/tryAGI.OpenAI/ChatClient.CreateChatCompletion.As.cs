// ReSharper disable RedundantNameQualifier

using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;

namespace tryAGI.OpenAI
{
    public partial class ChatClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="model"></param>
        /// <param name="store"></param>
        /// <param name="metadata"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="logprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="n"></param>
        /// <param name="modalities"></param>
        /// <param name="audio"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="responseFormat"></param>
        /// <param name="seed"></param>
        /// <param name="serviceTier"></param>
        /// <param name="stop"></param>
        /// <param name="stream"></param>
        /// <param name="streamOptions"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="user"></param>
        /// <param name="strict"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <param name="cancellationToken"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        // <inheritdoc cref="CreateChatCompletionAsync(System.Collections.Generic.IList{ChatCompletionRequestMessage},tryAGI.OpenAI.AnyOf{string?,tryAGI.OpenAI.CreateChatCompletionRequestModel?},bool?,System.Collections.Generic.Dictionary{string, string}?,double?,global::System.Collections.Generic.Dictionary{string, int}?,bool?,int?,int?,int?,System.Collections.Generic.IList{global::tryAGI.OpenAI.ChatCompletionModalitie}?,global::tryAGI.OpenAI.PredictionContent?,tryAGI.OpenAI.CreateChatCompletionRequestAudio?,double?,tryAGI.OpenAI.ResponseFormat?,int?,tryAGI.OpenAI.CreateChatCompletionRequestServiceTier?,tryAGI.OpenAI.OneOf{string?,System.Collections.Generic.IList{string}}?,bool?,tryAGI.OpenAI.ChatCompletionStreamOptions?,double?,double?,System.Collections.Generic.IList{ChatCompletionTool}?,tryAGI.OpenAI.ChatCompletionToolChoiceOption?,bool?,string?,System.Threading.CancellationToken)"/>
#if NET6_0_OR_GREATER
        [RequiresUnreferencedCode(
            "This method uses reflection to generate a JSON schema. Use overload with JsonTypeInfo parameter to avoid this.")]
#endif
#if NET8_0_OR_GREATER
        [RequiresDynamicCode("This method uses reflection to generate a JSON schema. Use overload with JsonTypeInfo parameter to avoid this.")]
#endif
        public async global::System.Threading.Tasks.Task<OpenAI.AnyOf<T, global::tryAGI.OpenAI.CreateChatCompletionResponse>>
            CreateChatCompletionAsAsync<T>(
                global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage> messages,
                global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateChatCompletionRequestModel?> model,
                bool? store = default,
                global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
                double? frequencyPenalty = default,
                global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
                bool? logprobs = default,
                int? topLogprobs = default,
                int? maxCompletionTokens = default,
                int? n = default,
                global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionModalitie>? modalities = default,
                global::tryAGI.OpenAI.CreateChatCompletionRequestAudio? audio = default,
                double? presencePenalty = default,
                global::tryAGI.OpenAI.ResponseFormat? responseFormat = default,
                int? seed = default,
                global::tryAGI.OpenAI.CreateChatCompletionRequestServiceTier? serviceTier = default,
                global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
                bool? stream = default,
                global::tryAGI.OpenAI.ChatCompletionStreamOptions? streamOptions = default,
                double? temperature = default,
                double? topP = default,
                global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? tools = default,
                global::tryAGI.OpenAI.ChatCompletionToolChoiceOption? toolChoice = default,
                bool? parallelToolCalls = default,
                string? user = default,
                bool? strict = true,
                JsonSerializerOptions? jsonSerializerOptions = null,
                global::System.Threading.CancellationToken cancellationToken = default)
            where T : class, new() // T should be json object
        {
            var request = new global::tryAGI.OpenAI.CreateChatCompletionRequest
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

        // <inheritdoc cref="CreateChatCompletionAsync(System.Collections.Generic.IList{tryAGI.OpenAI.ChatCompletionRequestMessage},tryAGI.OpenAI.AnyOf{string?,tryAGI.OpenAI.CreateChatCompletionRequestModel?},bool?,System.Collections.Generic.Dictionary{string, string}?,double?,global::System.Collections.Generic.Dictionary{string, int}?,bool?,int?,int?,int?,System.Collections.Generic.IList{global::tryAGI.OpenAI.ChatCompletionModalitie}?,global::tryAGI.OpenAI.PredictionContent?,tryAGI.OpenAI.CreateChatCompletionRequestAudio?,double?,tryAGI.OpenAI.ResponseFormat?,int?,tryAGI.OpenAI.CreateChatCompletionRequestServiceTier?,tryAGI.OpenAI.OneOf{string?,System.Collections.Generic.IList{string}}?,bool?,tryAGI.OpenAI.ChatCompletionStreamOptions?,double?,double?,System.Collections.Generic.IList{tryAGI.OpenAI.ChatCompletionTool}?,tryAGI.OpenAI.ChatCompletionToolChoiceOption?,bool?,string?,System.Threading.CancellationToken)"/>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="jsonTypeInfo"></param>
        /// <param name="messages"></param>
        /// <param name="model"></param>
        /// <param name="store"></param>
        /// <param name="metadata"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="logprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="n"></param>
        /// <param name="modalities"></param>
        /// <param name="audio"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="responseFormat"></param>
        /// <param name="seed"></param>
        /// <param name="serviceTier"></param>
        /// <param name="stop"></param>
        /// <param name="stream"></param>
        /// <param name="streamOptions"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="user"></param>
        /// <param name="strict"></param>
        /// <param name="cancellationToken"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async global::System.Threading.Tasks.Task<OpenAI.AnyOf<T, global::tryAGI.OpenAI.CreateChatCompletionResponse>>
            CreateChatCompletionAsAsync<T>(
                JsonTypeInfo<T> jsonTypeInfo,
                global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage> messages,
                global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateChatCompletionRequestModel?> model,
                bool? store = default,
                global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
                double? frequencyPenalty = default,
                global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
                bool? logprobs = default,
                int? topLogprobs = default,
                int? maxCompletionTokens = default,
                int? n = default,
                global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionModalitie>? modalities = default,
                global::tryAGI.OpenAI.CreateChatCompletionRequestAudio? audio = default,
                double? presencePenalty = default,
                global::tryAGI.OpenAI.ResponseFormat? responseFormat = default,
                int? seed = default,
                global::tryAGI.OpenAI.CreateChatCompletionRequestServiceTier? serviceTier = default,
                global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
                bool? stream = default,
                global::tryAGI.OpenAI.ChatCompletionStreamOptions? streamOptions = default,
                double? temperature = default,
                double? topP = default,
                global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? tools = default,
                global::tryAGI.OpenAI.ChatCompletionToolChoiceOption? toolChoice = default,
                bool? parallelToolCalls = default,
                string? user = default,
                bool? strict = true,
                global::System.Threading.CancellationToken cancellationToken = default)
            where T : class, new() // T should be json object
        {
            var request = new global::tryAGI.OpenAI.CreateChatCompletionRequest
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
