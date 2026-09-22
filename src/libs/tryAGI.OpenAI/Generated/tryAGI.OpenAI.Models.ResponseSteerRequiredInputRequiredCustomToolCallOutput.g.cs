
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supply `output` using the custom tool call output input schema. The<br/>
    /// original custom tool call supplies the tool's name.
    /// </summary>
    public sealed partial class ResponseSteerRequiredInputRequiredCustomToolCallOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredCustomToolCallOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredCustomToolCallOutput" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSteerRequiredInputRequiredCustomToolCallOutput(
            string callId,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType type)
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredCustomToolCallOutput" /> class.
        /// </summary>
        public ResponseSteerRequiredInputRequiredCustomToolCallOutput()
        {
        }

    }
}