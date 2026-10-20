
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionRequest
    {
        /// <summary>
        /// The model to use. Only `gpt-6-luna` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The input to evaluate for every question. Provide a text string or an ordered array of messages, function calls and outputs, or custom tool calls and outputs. Each tool output must identify a matching call by call ID. User messages and tool outputs can contain text and images; developer and system messages can contain only input text, and assistant messages can contain output text or refusals. Images can be base64 data URLs or publicly accessible HTTP(S) URLs; at most 128 images are allowed per request. Files, audio, and item references are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.DecisionInput Input { get; set; }

        /// <summary>
        /// Ask 1–400 questions about the input. Each question can be a predicate, choice, or score. Answers come back in the same order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam> Questions { get; set; }

        /// <summary>
        /// Opaque caller-provided end-user identifier, scoped by the verified org. Match Responses' limit; this is never the authenticated user identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// Partition prompt cache reuse by caller-provided key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// Options for prompt caching. Supported for `gpt-5.6` and later models. By default, OpenAI automatically chooses one implicit cache breakpoint. You can add explicit breakpoints to content blocks with `prompt_cache_breakpoint`. Each request can write up to four breakpoints. For cache matching, OpenAI considers up to the latest 80 breakpoints in the conversation, without a content-block lookback limit. Set `mode` to `explicit` to disable the implicit breakpoint. The `ttl` defaults to `30m`, which is currently the only supported value. See the [prompt caching guide](https://developers.openai.com/api/docs/guides/prompt-caching) for current details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_options")]
        public global::tryAGI.OpenAI.DecisionRequestPromptCacheOptions? PromptCacheOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use. Only `gpt-6-luna` is supported.
        /// </param>
        /// <param name="input">
        /// The input to evaluate for every question. Provide a text string or an ordered array of messages, function calls and outputs, or custom tool calls and outputs. Each tool output must identify a matching call by call ID. User messages and tool outputs can contain text and images; developer and system messages can contain only input text, and assistant messages can contain output text or refusals. Images can be base64 data URLs or publicly accessible HTTP(S) URLs; at most 128 images are allowed per request. Files, audio, and item references are not supported.
        /// </param>
        /// <param name="questions">
        /// Ask 1–400 questions about the input. Each question can be a predicate, choice, or score. Answers come back in the same order.
        /// </param>
        /// <param name="safetyIdentifier">
        /// Opaque caller-provided end-user identifier, scoped by the verified org. Match Responses' limit; this is never the authenticated user identity.
        /// </param>
        /// <param name="promptCacheKey">
        /// Partition prompt cache reuse by caller-provided key.
        /// </param>
        /// <param name="promptCacheOptions">
        /// Options for prompt caching. Supported for `gpt-5.6` and later models. By default, OpenAI automatically chooses one implicit cache breakpoint. You can add explicit breakpoints to content blocks with `prompt_cache_breakpoint`. Each request can write up to four breakpoints. For cache matching, OpenAI considers up to the latest 80 breakpoints in the conversation, without a content-block lookback limit. Set `mode` to `explicit` to disable the implicit breakpoint. The `ttl` defaults to `30m`, which is currently the only supported value. See the [prompt caching guide](https://developers.openai.com/api/docs/guides/prompt-caching) for current details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionRequest(
            string model,
            global::tryAGI.OpenAI.DecisionInput input,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam> questions,
            string? safetyIdentifier,
            string? promptCacheKey,
            global::tryAGI.OpenAI.DecisionRequestPromptCacheOptions? promptCacheOptions)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
            this.SafetyIdentifier = safetyIdentifier;
            this.PromptCacheKey = promptCacheKey;
            this.PromptCacheOptions = promptCacheOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionRequest" /> class.
        /// </summary>
        public DecisionRequest()
        {
        }

    }
}