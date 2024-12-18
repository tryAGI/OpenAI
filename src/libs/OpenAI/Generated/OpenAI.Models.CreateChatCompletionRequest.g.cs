
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionRequest
    {
        /// <summary>
        /// A list of messages comprising the conversation so far. Depending on the<br/>
        /// [model](/docs/models) you use, different message types (modalities) are<br/>
        /// supported, like [text](/docs/guides/text-generation),<br/>
        /// [images](/docs/guides/vision), and [audio](/docs/guides/audio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessage> Messages { get; set; }

        /// <summary>
        /// ID of the model to use. See the [model endpoint compatibility](/docs/models#model-endpoint-compatibility) table for details on which models work with the Chat API.<br/>
        /// Example: gpt-4o
        /// </summary>
        /// <example>gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.AnyOfJsonConverter<string, global::OpenAI.CreateChatCompletionRequestModel?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.AnyOf<string, global::OpenAI.CreateChatCompletionRequestModel?> Model { get; set; }

        /// <summary>
        /// Whether or not to store the output of this chat completion request for <br/>
        /// use in our [model distillation](/docs/guides/distillation) or<br/>
        /// [evals](/docs/guides/evals) products.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// **o1 models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.CreateChatCompletionRequestReasoningEffortJsonConverter))]
        public global::OpenAI.CreateChatCompletionRequestReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Developer-defined tags and values used for filtering completions<br/>
        /// in the [dashboard](https://platform.openai.com/chat-completions).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on<br/>
        /// their existing frequency in the text so far, decreasing the model's<br/>
        /// likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Modify the likelihood of specified tokens appearing in the completion.<br/>
        /// Accepts a JSON object that maps tokens (specified by their token ID in the<br/>
        /// tokenizer) to an associated bias value from -100 to 100. Mathematically,<br/>
        /// the bias is added to the logits generated by the model prior to sampling.<br/>
        /// The exact effect will vary per model, but values between -1 and 1 should<br/>
        /// decrease or increase likelihood of selection; values like -100 or 100<br/>
        /// should result in a ban or exclusive selection of the relevant token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, int>? LogitBias { get; set; }

        /// <summary>
        /// Whether to return log probabilities of the output tokens or not. If true,<br/>
        /// returns the log probabilities of each output token returned in the<br/>
        /// `content` of `message`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// An integer between 0 and 20 specifying the number of most likely tokens to<br/>
        /// return at each token position, each with an associated log probability.<br/>
        /// `logprobs` must be set to `true` if this parameter is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// The maximum number of [tokens](/tokenizer) that can be generated in the<br/>
        /// chat completion. This value can be used to control<br/>
        /// [costs](https://openai.com/api/pricing/) for text generated via API.<br/>
        /// This value is now deprecated in favor of `max_completion_tokens`, and is<br/>
        /// not compatible with [o1 series models](/docs/guides/reasoning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// An upper bound for the number of tokens that can be generated for a completion, including visible output tokens and [reasoning tokens](/docs/guides/reasoning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// How many chat completion choices to generate for each input message. Note that you will be charged based on the number of generated tokens across all of the choices. Keep `n` as `1` to minimize costs.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Output types that you would like the model to generate for this request.<br/>
        /// Most models are capable of generating text, which is the default:<br/>
        /// `["text"]`<br/>
        /// The `gpt-4o-audio-preview` model can also be used to [generate audio](/docs/guides/audio). To<br/>
        /// request that this model generate both text and audio responses, you can<br/>
        /// use:<br/>
        /// `["text", "audio"]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionModalitie>? Modalities { get; set; }

        /// <summary>
        /// Configuration for a [Predicted Output](/docs/guides/predicted-outputs),<br/>
        /// which can greatly improve response times when large parts of the model<br/>
        /// response are known ahead of time. This is most common when you are<br/>
        /// regenerating a file with only minor changes to most of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        public global::OpenAI.PredictionContent? Prediction { get; set; }

        /// <summary>
        /// Parameters for audio output. Required when audio output is requested with<br/>
        /// `modalities: ["audio"]`. [Learn more](/docs/guides/audio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::OpenAI.CreateChatCompletionRequestAudio? Audio { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on<br/>
        /// whether they appear in the text so far, increasing the model's likelihood<br/>
        /// to talk about new topics.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
        /// Structured Outputs which ensures the model will match your supplied JSON<br/>
        /// schema. Learn more in the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures<br/>
        /// the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model<br/>
        /// to produce JSON yourself via a system or user message. Without this, the<br/>
        /// model may generate an unending stream of whitespace until the generation<br/>
        /// reaches the token limit, resulting in a long-running and seemingly "stuck"<br/>
        /// request. Also note that the message content may be partially cut off if<br/>
        /// `finish_reason="length"`, which indicates the generation exceeded<br/>
        /// `max_tokens` or the conversation exceeded the max context length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.ResponseFormatJsonConverter))]
        public global::OpenAI.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// This feature is in Beta.<br/>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:<br/>
        ///   - If set to 'auto', and the Project is Scale tier enabled, the system will utilize scale tier credits until they are exhausted.<br/>
        ///   - If set to 'auto', and the Project is not Scale tier enabled, the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - When not set, the default behavior is 'auto'.<br/>
        ///   When this parameter is set, the response body will include the `service_tier` utilized.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.CreateChatCompletionRequestServiceTierJsonConverter))]
        public global::OpenAI.CreateChatCompletionRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Options for streaming response. Only set this when you set `stream: true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::OpenAI.ChatCompletionStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// We generally recommend altering this or `top_p` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling,<br/>
        /// where the model considers the results of the tokens with top_p probability<br/>
        /// mass. So 0.1 means only the tokens comprising the top 10% probability mass<br/>
        /// are considered.<br/>
        /// We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter))]
        public global::OpenAI.ChatCompletionToolChoiceOption? ToolChoice { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Deprecated in favor of `tool_choice`.<br/>
        /// Controls which (if any) function is called by the model.<br/>
        /// `none` means the model will not call a function and instead generates a<br/>
        /// message.<br/>
        /// `auto` means the model can pick between generating a message or calling a<br/>
        /// function.<br/>
        /// Specifying a particular function via `{"name": "my_function"}` forces the<br/>
        /// model to call that function.<br/>
        /// `none` is the default when no functions are present. `auto` is the default<br/>
        /// if functions are present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverter<global::OpenAI.CreateChatCompletionRequestFunctionCall?, global::OpenAI.ChatCompletionFunctionCallOption>))]
        public global::OpenAI.OneOf<global::OpenAI.CreateChatCompletionRequestFunctionCall?, global::OpenAI.ChatCompletionFunctionCallOption>? FunctionCall { get; set; }

        /// <summary>
        /// Deprecated in favor of `tools`.<br/>
        /// A list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionFunctions>? Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far. Depending on the<br/>
        /// [model](/docs/models) you use, different message types (modalities) are<br/>
        /// supported, like [text](/docs/guides/text-generation),<br/>
        /// [images](/docs/guides/vision), and [audio](/docs/guides/audio).
        /// </param>
        /// <param name="model">
        /// ID of the model to use. See the [model endpoint compatibility](/docs/models#model-endpoint-compatibility) table for details on which models work with the Chat API.<br/>
        /// Example: gpt-4o
        /// </param>
        /// <param name="store">
        /// Whether or not to store the output of this chat completion request for <br/>
        /// use in our [model distillation](/docs/guides/distillation) or<br/>
        /// [evals](/docs/guides/evals) products.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="reasoningEffort">
        /// **o1 models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="metadata">
        /// Developer-defined tags and values used for filtering completions<br/>
        /// in the [dashboard](https://platform.openai.com/chat-completions).
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on<br/>
        /// their existing frequency in the text so far, decreasing the model's<br/>
        /// likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion.<br/>
        /// Accepts a JSON object that maps tokens (specified by their token ID in the<br/>
        /// tokenizer) to an associated bias value from -100 to 100. Mathematically,<br/>
        /// the bias is added to the logits generated by the model prior to sampling.<br/>
        /// The exact effect will vary per model, but values between -1 and 1 should<br/>
        /// decrease or increase likelihood of selection; values like -100 or 100<br/>
        /// should result in a ban or exclusive selection of the relevant token.
        /// </param>
        /// <param name="logprobs">
        /// Whether to return log probabilities of the output tokens or not. If true,<br/>
        /// returns the log probabilities of each output token returned in the<br/>
        /// `content` of `message`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topLogprobs">
        /// An integer between 0 and 20 specifying the number of most likely tokens to<br/>
        /// return at each token position, each with an associated log probability.<br/>
        /// `logprobs` must be set to `true` if this parameter is used.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// An upper bound for the number of tokens that can be generated for a completion, including visible output tokens and [reasoning tokens](/docs/guides/reasoning).
        /// </param>
        /// <param name="n">
        /// How many chat completion choices to generate for each input message. Note that you will be charged based on the number of generated tokens across all of the choices. Keep `n` as `1` to minimize costs.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="modalities">
        /// Output types that you would like the model to generate for this request.<br/>
        /// Most models are capable of generating text, which is the default:<br/>
        /// `["text"]`<br/>
        /// The `gpt-4o-audio-preview` model can also be used to [generate audio](/docs/guides/audio). To<br/>
        /// request that this model generate both text and audio responses, you can<br/>
        /// use:<br/>
        /// `["text", "audio"]`
        /// </param>
        /// <param name="prediction">
        /// Configuration for a [Predicted Output](/docs/guides/predicted-outputs),<br/>
        /// which can greatly improve response times when large parts of the model<br/>
        /// response are known ahead of time. This is most common when you are<br/>
        /// regenerating a file with only minor changes to most of the content.
        /// </param>
        /// <param name="audio">
        /// Parameters for audio output. Required when audio output is requested with<br/>
        /// `modalities: ["audio"]`. [Learn more](/docs/guides/audio).
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on<br/>
        /// whether they appear in the text so far, increasing the model's likelihood<br/>
        /// to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
        /// Structured Outputs which ensures the model will match your supplied JSON<br/>
        /// schema. Learn more in the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures<br/>
        /// the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model<br/>
        /// to produce JSON yourself via a system or user message. Without this, the<br/>
        /// model may generate an unending stream of whitespace until the generation<br/>
        /// reaches the token limit, resulting in a long-running and seemingly "stuck"<br/>
        /// request. Also note that the message content may be partially cut off if<br/>
        /// `finish_reason="length"`, which indicates the generation exceeded<br/>
        /// `max_tokens` or the conversation exceeded the max context length.
        /// </param>
        /// <param name="seed">
        /// This feature is in Beta.<br/>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </param>
        /// <param name="serviceTier">
        /// Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:<br/>
        ///   - If set to 'auto', and the Project is Scale tier enabled, the system will utilize scale tier credits until they are exhausted.<br/>
        ///   - If set to 'auto', and the Project is not Scale tier enabled, the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - When not set, the default behavior is 'auto'.<br/>
        ///   When this parameter is set, the response body will include the `service_tier` utilized.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </param>
        /// <param name="stream">
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Options for streaming response. Only set this when you set `stream: true`.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// We generally recommend altering this or `top_p` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling,<br/>
        /// where the model considers the results of the tokens with top_p probability<br/>
        /// mass. So 0.1 means only the tokens comprising the top 10% probability mass<br/>
        /// are considered.<br/>
        /// We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateChatCompletionRequest(
            global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessage> messages,
            global::OpenAI.AnyOf<string, global::OpenAI.CreateChatCompletionRequestModel?> model,
            bool? store,
            global::OpenAI.CreateChatCompletionRequestReasoningEffort? reasoningEffort,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            double? frequencyPenalty,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias,
            bool? logprobs,
            int? topLogprobs,
            int? maxCompletionTokens,
            int? n,
            global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionModalitie>? modalities,
            global::OpenAI.PredictionContent? prediction,
            global::OpenAI.CreateChatCompletionRequestAudio? audio,
            double? presencePenalty,
            global::OpenAI.ResponseFormat? responseFormat,
            int? seed,
            global::OpenAI.CreateChatCompletionRequestServiceTier? serviceTier,
            global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            bool? stream,
            global::OpenAI.ChatCompletionStreamOptions? streamOptions,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool>? tools,
            global::OpenAI.ChatCompletionToolChoiceOption? toolChoice,
            bool? parallelToolCalls,
            string? user)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model;
            this.Store = store;
            this.ReasoningEffort = reasoningEffort;
            this.Metadata = metadata;
            this.FrequencyPenalty = frequencyPenalty;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.TopLogprobs = topLogprobs;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.N = n;
            this.Modalities = modalities;
            this.Prediction = prediction;
            this.Audio = audio;
            this.PresencePenalty = presencePenalty;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.ServiceTier = serviceTier;
            this.Stop = stop;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        public CreateChatCompletionRequest()
        {
        }
    }
}