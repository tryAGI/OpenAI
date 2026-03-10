
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolSearchCall
    {
        /// <summary>
        /// The type of the item. Always `tool_search_call`.<br/>
        /// Default Value: tool_search_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ToolSearchCallType.ToolSearchCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolSearchCallType Type { get; set; } = global::tryAGI.OpenAI.ToolSearchCallType.ToolSearchCall;

        /// <summary>
        /// The unique ID of the tool search call item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// Whether tool search was executed by the server or by the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ToolSearchExecutionType Execution { get; set; }

        /// <summary>
        /// Arguments used for the tool search call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// The status of the tool search call item that was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FunctionCallStatus Status { get; set; }

        /// <summary>
        /// The identifier of the actor that created the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchCall" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `tool_search_call`.<br/>
        /// Default Value: tool_search_call
        /// </param>
        /// <param name="id">
        /// The unique ID of the tool search call item.
        /// </param>
        /// <param name="callId"></param>
        /// <param name="execution">
        /// Whether tool search was executed by the server or by the client.
        /// </param>
        /// <param name="arguments">
        /// Arguments used for the tool search call.
        /// </param>
        /// <param name="status">
        /// The status of the tool search call item that was recorded.
        /// </param>
        /// <param name="createdBy">
        /// The identifier of the actor that created the item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchCall(
            string id,
            global::tryAGI.OpenAI.ToolSearchExecutionType execution,
            object arguments,
            global::tryAGI.OpenAI.FunctionCallStatus status,
            string? callId,
            string? createdBy,
            global::tryAGI.OpenAI.ToolSearchCallType type = global::tryAGI.OpenAI.ToolSearchCallType.ToolSearchCall)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Execution = execution;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Status = status;
            this.Type = type;
            this.CallId = callId;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchCall" /> class.
        /// </summary>
        public ToolSearchCall()
        {
        }
    }
}