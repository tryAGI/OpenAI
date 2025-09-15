
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRunRequestWithoutStream
    {
        /// <summary>
        /// Appends additional instructions at the end of the instructions for the run. This is useful for modifying the behavior on a per-run basis without overriding other instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_instructions")]
        public string? AdditionalInstructions { get; set; }

        /// <summary>
        /// Adds additional messages to the thread before creating the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_messages")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? AdditionalMessages { get; set; }

        /// <summary>
        /// The ID of the [assistant](https://platform.openai.com/docs/api-reference/assistants) to use to execute this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantId { get; set; }

        /// <summary>
        /// Overrides the [instructions](https://platform.openai.com/docs/api-reference/assistants/createAssistant) of the assistant. This is useful for modifying the behavior on a per-run basis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The maximum number of completion tokens that may be used over the course of the run. The run will make a best effort to use only the number of completion tokens specified, across multiple turns of the run. If the run exceeds the number of completion tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// The maximum number of prompt tokens that may be used over the course of the run. The run will make a best effort to use only the number of prompt tokens specified, across multiple turns of the run. If the run exceeds the number of prompt tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_tokens")]
        public int? MaxPromptTokens { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard.<br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The ID of the [Model](https://platform.openai.com/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>? Model { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](https://platform.openai.com/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Constrains effort on reasoning for<br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `minimal`, `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningEffortJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Specifies the format that the model must output. Compatible with [GPT-4o](https://platform.openai.com/docs/models#gpt-4o), [GPT-4 Turbo](https://platform.openai.com/docs/models#gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](https://platform.openai.com/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter))]
        public global::tryAGI.OpenAI.AssistantsApiResponseFormatOption? ResponseFormat { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tools and instead generates a message.<br/>
        /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools before responding to the user.<br/>
        /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter))]
        public global::tryAGI.OpenAI.AssistantsApiToolChoiceOption? ToolChoice { get; set; }

        /// <summary>
        /// Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssistantTool>? Tools { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// We generally recommend altering this or temperature but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Controls for how a thread will be truncated prior to the run. Use this to control the initial context window of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation_strategy")]
        public global::tryAGI.OpenAI.TruncationObject? TruncationStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunRequestWithoutStream" /> class.
        /// </summary>
        /// <param name="additionalInstructions">
        /// Appends additional instructions at the end of the instructions for the run. This is useful for modifying the behavior on a per-run basis without overriding other instructions.
        /// </param>
        /// <param name="additionalMessages">
        /// Adds additional messages to the thread before creating the run.
        /// </param>
        /// <param name="assistantId">
        /// The ID of the [assistant](https://platform.openai.com/docs/api-reference/assistants) to use to execute this run.
        /// </param>
        /// <param name="instructions">
        /// Overrides the [instructions](https://platform.openai.com/docs/api-reference/assistants/createAssistant) of the assistant. This is useful for modifying the behavior on a per-run basis.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of completion tokens that may be used over the course of the run. The run will make a best effort to use only the number of completion tokens specified, across multiple turns of the run. If the run exceeds the number of completion tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </param>
        /// <param name="maxPromptTokens">
        /// The maximum number of prompt tokens that may be used over the course of the run. The run will make a best effort to use only the number of prompt tokens specified, across multiple turns of the run. If the run exceeds the number of prompt tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard.<br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="model">
        /// The ID of the [Model](https://platform.openai.com/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](https://platform.openai.com/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </param>
        /// <param name="reasoningEffort">
        /// Constrains effort on reasoning for<br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `minimal`, `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format that the model must output. Compatible with [GPT-4o](https://platform.openai.com/docs/models#gpt-4o), [GPT-4 Turbo](https://platform.openai.com/docs/models#gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](https://platform.openai.com/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tools and instead generates a message.<br/>
        /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools before responding to the user.<br/>
        /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
        /// </param>
        /// <param name="tools">
        /// Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis.
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// We generally recommend altering this or temperature but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="truncationStrategy">
        /// Controls for how a thread will be truncated prior to the run. Use this to control the initial context window of the run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRunRequestWithoutStream(
            string assistantId,
            string? additionalInstructions,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? additionalMessages,
            string? instructions,
            int? maxCompletionTokens,
            int? maxPromptTokens,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>? model,
            bool? parallelToolCalls,
            global::tryAGI.OpenAI.ReasoningEffort? reasoningEffort,
            global::tryAGI.OpenAI.AssistantsApiResponseFormatOption? responseFormat,
            double? temperature,
            global::tryAGI.OpenAI.AssistantsApiToolChoiceOption? toolChoice,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AssistantTool>? tools,
            double? topP,
            global::tryAGI.OpenAI.TruncationObject? truncationStrategy)
        {
            this.AssistantId = assistantId ?? throw new global::System.ArgumentNullException(nameof(assistantId));
            this.AdditionalInstructions = additionalInstructions;
            this.AdditionalMessages = additionalMessages;
            this.Instructions = instructions;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxPromptTokens = maxPromptTokens;
            this.Metadata = metadata;
            this.Model = model;
            this.ParallelToolCalls = parallelToolCalls;
            this.ReasoningEffort = reasoningEffort;
            this.ResponseFormat = responseFormat;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopP = topP;
            this.TruncationStrategy = truncationStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunRequestWithoutStream" /> class.
        /// </summary>
        public CreateRunRequestWithoutStream()
        {
        }
    }
}