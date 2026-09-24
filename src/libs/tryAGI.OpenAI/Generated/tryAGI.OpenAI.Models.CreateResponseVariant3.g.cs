
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateResponseVariant3
    {
        /// <summary>
        /// Domain-specific access programs to use for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_programs")]
        public global::tryAGI.OpenAI.AccessProgramsParam? AccessPrograms { get; set; }

        /// <summary>
        /// Options for prompt caching. Supported for `gpt-5.6` and later models. By default, OpenAI automatically chooses one implicit cache breakpoint. You can add explicit breakpoints to content blocks with `prompt_cache_breakpoint`. Each request can write up to four breakpoints. For cache matching, OpenAI considers up to the latest 80 breakpoints in the conversation, without a content-block lookback limit. Set `mode` to `explicit` to disable the implicit breakpoint. The `ttl` defaults to `30m`, which is currently the only supported value. See the [prompt caching guide](https://developers.openai.com/api/docs/guides/prompt-caching) for current details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_options")]
        public global::tryAGI.OpenAI.ResponsePromptCacheOptionsParam? PromptCacheOptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::tryAGI.OpenAI.ServiceTierResponsesEnum? ServiceTier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::tryAGI.OpenAI.CreateResponseVariant3Truncation? Truncation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.Reasoning? Reasoning { get; set; }

        /// <summary>
        /// Text, image, or file inputs to the model, used to generate a response.<br/>
        /// Learn more:<br/>
        /// - [Text inputs and outputs](https://developers.openai.com/api/docs/guides/text)<br/>
        /// - [Image inputs](https://developers.openai.com/api/docs/guides/images-vision)<br/>
        /// - [File inputs](https://developers.openai.com/api/docs/guides/file-inputs)<br/>
        /// - [Conversation state](https://developers.openai.com/api/docs/guides/conversation-state)<br/>
        /// - [Function calling](https://developers.openai.com/api/docs/guides/function-calling)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputParamJsonConverter))]
        public global::tryAGI.OpenAI.InputParam? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? Include { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        public global::tryAGI.OpenAI.ModerationParam? Moderation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::tryAGI.OpenAI.ResponseStreamOptionsVariant1? StreamOptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::tryAGI.OpenAI.ConversationParam? Conversation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_management")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>? ContextManagement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant3" /> class.
        /// </summary>
        /// <param name="accessPrograms">
        /// Domain-specific access programs to use for this request.
        /// </param>
        /// <param name="promptCacheOptions">
        /// Options for prompt caching. Supported for `gpt-5.6` and later models. By default, OpenAI automatically chooses one implicit cache breakpoint. You can add explicit breakpoints to content blocks with `prompt_cache_breakpoint`. Each request can write up to four breakpoints. For cache matching, OpenAI considers up to the latest 80 breakpoints in the conversation, without a content-block lookback limit. Set `mode` to `explicit` to disable the implicit breakpoint. The `ttl` defaults to `30m`, which is currently the only supported value. See the [prompt caching guide](https://developers.openai.com/api/docs/guides/prompt-caching) for current details.
        /// </param>
        /// <param name="serviceTier"></param>
        /// <param name="reasoning"></param>
        /// <param name="input">
        /// Text, image, or file inputs to the model, used to generate a response.<br/>
        /// Learn more:<br/>
        /// - [Text inputs and outputs](https://developers.openai.com/api/docs/guides/text)<br/>
        /// - [Image inputs](https://developers.openai.com/api/docs/guides/images-vision)<br/>
        /// - [File inputs](https://developers.openai.com/api/docs/guides/file-inputs)<br/>
        /// - [Conversation state](https://developers.openai.com/api/docs/guides/conversation-state)<br/>
        /// - [Function calling](https://developers.openai.com/api/docs/guides/function-calling)
        /// </param>
        /// <param name="include"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="store"></param>
        /// <param name="instructions"></param>
        /// <param name="moderation"></param>
        /// <param name="stream"></param>
        /// <param name="streamOptions"></param>
        /// <param name="conversation"></param>
        /// <param name="contextManagement"></param>
        /// <param name="maxOutputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseVariant3(
            global::tryAGI.OpenAI.AccessProgramsParam? accessPrograms,
            global::tryAGI.OpenAI.ResponsePromptCacheOptionsParam? promptCacheOptions,
            global::tryAGI.OpenAI.ServiceTierResponsesEnum? serviceTier,
            global::tryAGI.OpenAI.Reasoning? reasoning,
            global::tryAGI.OpenAI.InputParam? input,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? include,
            bool? parallelToolCalls,
            bool? store,
            string? instructions,
            global::tryAGI.OpenAI.ModerationParam? moderation,
            bool? stream,
            global::tryAGI.OpenAI.ResponseStreamOptionsVariant1? streamOptions,
            global::tryAGI.OpenAI.ConversationParam? conversation,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>? contextManagement,
            int? maxOutputTokens)
        {
            this.AccessPrograms = accessPrograms;
            this.PromptCacheOptions = promptCacheOptions;
            this.ServiceTier = serviceTier;
            this.Reasoning = reasoning;
            this.Input = input;
            this.Include = include;
            this.ParallelToolCalls = parallelToolCalls;
            this.Store = store;
            this.Instructions = instructions;
            this.Moderation = moderation;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Conversation = conversation;
            this.ContextManagement = contextManagement;
            this.MaxOutputTokens = maxOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant3" /> class.
        /// </summary>
        public CreateResponseVariant3()
        {
        }

    }
}