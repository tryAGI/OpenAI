
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionInputCustomToolCall
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::tryAGI.OpenAI.FunctionCallStatusParam? Status { get; set; }

        /// <summary>
        /// Default Value: custom_tool_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputCustomToolCallType.CustomToolCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputCustomToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallType Type { get; set; } = global::tryAGI.OpenAI.DecisionInputCustomToolCallType.CustomToolCall;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputCustomToolCall" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="name"></param>
        /// <param name="input"></param>
        /// <param name="id"></param>
        /// <param name="namespace"></param>
        /// <param name="status"></param>
        /// <param name="type">
        /// Default Value: custom_tool_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputCustomToolCall(
            string callId,
            string name,
            string input,
            string? id,
            string? @namespace,
            global::tryAGI.OpenAI.FunctionCallStatusParam? status,
            global::tryAGI.OpenAI.DecisionInputCustomToolCallType type = global::tryAGI.OpenAI.DecisionInputCustomToolCallType.CustomToolCall)
        {
            this.Id = id;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Namespace = @namespace;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputCustomToolCall" /> class.
        /// </summary>
        public DecisionInputCustomToolCall()
        {
        }

    }
}