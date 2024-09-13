
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Represents an execution run on a [thread](/docs/api-reference/threads).
    /// </summary>
    public sealed partial class RunObject
    {
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `thread.run`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RunObjectObjectJsonConverter))]
        public global::OpenAI.RunObjectObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The ID of the [thread](/docs/api-reference/threads) that was executed on as a part of this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

        /// <summary>
        /// The ID of the [assistant](/docs/api-reference/assistants) used for execution of this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantId { get; set; }

        /// <summary>
        /// The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, `incomplete`, or `expired`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RunObjectStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunObjectStatus Status { get; set; }

        /// <summary>
        /// Details on the action required to continue the run. Will be `null` if no action is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunObjectRequiredAction? RequiredAction { get; set; }

        /// <summary>
        /// The last error associated with this run. Will be `null` if there are no errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunObjectLastError? LastError { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? StartedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? CancelledAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? FailedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// Details on why the run is incomplete. Will be `null` if the run is not incomplete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunObjectIncompleteDetails? IncompleteDetails { get; set; }

        /// <summary>
        /// The model that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The instructions that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// The list of tools that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.OneOf<global::OpenAI.AssistantToolsCode, global::OpenAI.AssistantToolsFileSearch, global::OpenAI.AssistantToolsFunction>> Tools { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunObjectMetadata? Metadata { get; set; }

        /// <summary>
        /// Usage statistics related to the run. This value will be `null` if the run is not in a terminal state (i.e. `in_progress`, `queued`, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunCompletionUsage? Usage { get; set; }

        /// <summary>
        /// The sampling temperature used for this run. If not set, defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The nucleus sampling value used for this run. If not set, defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// The maximum number of prompt tokens specified to have been used over the course of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? MaxPromptTokens { get; set; }

        /// <summary>
        /// The maximum number of completion tokens specified to have been used over the course of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Controls for how a thread will be truncated prior to the run. Use this to control the intial context window of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation_strategy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.TruncationObject TruncationStrategy { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tools and instead generates a message.<br/>
        /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools before responding to the user.<br/>
        /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.AssistantsApiToolChoiceOption ToolChoice { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](/docs/guides/function-calling/parallel-function-calling) during tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models/gpt-4o), [GPT-4 Turbo](/docs/models/gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.AssistantsApiResponseFormatOption ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}