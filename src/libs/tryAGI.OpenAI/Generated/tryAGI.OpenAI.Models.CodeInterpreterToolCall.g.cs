
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool call to run code.
    /// </summary>
    public sealed partial class CodeInterpreterToolCall
    {
        /// <summary>
        /// The type of the code interpreter tool call. Always `code_interpreter_call`.<br/>
        /// Default Value: code_interpreter_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CodeInterpreterToolCallType.CodeInterpreterCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.CodeInterpreterToolCallType Type { get; set; } = global::tryAGI.OpenAI.CodeInterpreterToolCallType.CodeInterpreterCall;

        /// <summary>
        /// The unique ID of the code interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The status of the code interpreter tool call. Valid values are `in_progress`, `completed`, `incomplete`, `interpreting`, and `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.CodeInterpreterToolCallStatus Status { get; set; } = default!;

        /// <summary>
        /// The ID of the container used to run the code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ContainerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item>? Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolCall" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the code interpreter tool call. Always `code_interpreter_call`.<br/>
        /// Default Value: code_interpreter_call
        /// </param>
        /// <param name="id">
        /// The unique ID of the code interpreter tool call.
        /// </param>
        /// <param name="status">
        /// The status of the code interpreter tool call. Valid values are `in_progress`, `completed`, `incomplete`, `interpreting`, and `failed`.
        /// </param>
        /// <param name="containerId">
        /// The ID of the container used to run the code.
        /// </param>
        /// <param name="code"></param>
        /// <param name="outputs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterToolCall(
            string id,
            global::tryAGI.OpenAI.CodeInterpreterToolCallStatus status,
            string containerId,
            string? code,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item>? outputs,
            global::tryAGI.OpenAI.CodeInterpreterToolCallType type = global::tryAGI.OpenAI.CodeInterpreterToolCallType.CodeInterpreterCall)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.Type = type;
            this.Code = code;
            this.Outputs = outputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolCall" /> class.
        /// </summary>
        public CodeInterpreterToolCall()
        {
        }
    }
}