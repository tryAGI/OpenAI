
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The result supplied for a function call.
    /// </summary>
    public sealed partial class FunctionCallOutputItemResource
    {
        /// <summary>
        /// The ID of the function call output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the turn that contains this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The item type. Always `function_call_output`.<br/>
        /// Default Value: function_call_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FunctionCallOutputItemResourceType.FunctionCallOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.FunctionCallOutputItemResourceType Type { get; set; } = global::tryAGI.OpenAI.FunctionCallOutputItemResourceType.FunctionCallOutput;

        /// <summary>
        /// The ID of the function call that produced this output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The status of the function call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FunctionCallStatusResource Status { get; set; }

        /// <summary>
        /// The function result, if the call succeeded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::tryAGI.OpenAI.FunctionCallOutputResource? Output { get; set; }

        /// <summary>
        /// The error message, if the call failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the function call output item.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="callId">
        /// The ID of the function call that produced this output.
        /// </param>
        /// <param name="status">
        /// The status of the function call.
        /// </param>
        /// <param name="output">
        /// The function result, if the call succeeded.
        /// </param>
        /// <param name="error">
        /// The error message, if the call failed.
        /// </param>
        /// <param name="type">
        /// The item type. Always `function_call_output`.<br/>
        /// Default Value: function_call_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallOutputItemResource(
            string id,
            string turnId,
            string callId,
            global::tryAGI.OpenAI.FunctionCallStatusResource status,
            global::tryAGI.OpenAI.FunctionCallOutputResource? output,
            string? error,
            global::tryAGI.OpenAI.FunctionCallOutputItemResourceType type = global::tryAGI.OpenAI.FunctionCallOutputItemResourceType.FunctionCallOutput)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Status = status;
            this.Output = output;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItemResource" /> class.
        /// </summary>
        public FunctionCallOutputItemResource()
        {
        }

    }
}