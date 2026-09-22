
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveTransportCallError
    {
        /// <summary>
        /// Default Value: call_error
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveTransportCallErrorType.CallError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveTransportCallErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveTransportCallErrorType Type { get; set; } = global::tryAGI.OpenAI.LiveTransportCallErrorType.CallError;

        /// <summary>
        /// The call setup failure code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The parameter related to the error, if any. Empty when no parameter applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportCallError" /> class.
        /// </summary>
        /// <param name="code">
        /// The call setup failure code.
        /// </param>
        /// <param name="message"></param>
        /// <param name="param">
        /// The parameter related to the error, if any. Empty when no parameter applies.
        /// </param>
        /// <param name="type">
        /// Default Value: call_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveTransportCallError(
            string code,
            string message,
            string? param,
            global::tryAGI.OpenAI.LiveTransportCallErrorType type = global::tryAGI.OpenAI.LiveTransportCallErrorType.CallError)
        {
            this.Type = type;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportCallError" /> class.
        /// </summary>
        public LiveTransportCallError()
        {
        }

    }
}