
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool call to run code.
    /// </summary>
    public sealed partial class BetaCodeInterpreterToolCall
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the code interpreter tool call. Always `code_interpreter_call`.<br/>
        /// Default Value: code_interpreter_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType.CodeInterpreterCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType Type { get; set; } = global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType.CodeInterpreterCall;

        /// <summary>
        /// The unique ID of the code interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the code interpreter tool call. Valid values are `in_progress`, `completed`, `incomplete`, `interpreting`, and `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus Status { get; set; }

        /// <summary>
        /// The ID of the container used to run the code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item2>? Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCodeInterpreterToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the code interpreter tool call.
        /// </param>
        /// <param name="status">
        /// The status of the code interpreter tool call. Valid values are `in_progress`, `completed`, `incomplete`, `interpreting`, and `failed`.
        /// </param>
        /// <param name="containerId">
        /// The ID of the container used to run the code.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="code"></param>
        /// <param name="outputs"></param>
        /// <param name="type">
        /// The type of the code interpreter tool call. Always `code_interpreter_call`.<br/>
        /// Default Value: code_interpreter_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCodeInterpreterToolCall(
            string id,
            global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus status,
            string containerId,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            string? code,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item2>? outputs,
            global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType type = global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType.CodeInterpreterCall)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.Code = code;
            this.Outputs = outputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCodeInterpreterToolCall" /> class.
        /// </summary>
        public BetaCodeInterpreterToolCall()
        {
        }

    }
}