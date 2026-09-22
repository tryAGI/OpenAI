
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaHTTPError
    {
        /// <summary>
        /// Default Value: http_error
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaHTTPErrorType.HttpError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaHTTPErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaHTTPErrorType Type { get; set; } = global::tryAGI.OpenAI.BetaHTTPErrorType.HttpError;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaHTTPError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="type">
        /// Default Value: http_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaHTTPError(
            int code,
            string message,
            global::tryAGI.OpenAI.BetaHTTPErrorType type = global::tryAGI.OpenAI.BetaHTTPErrorType.HttpError)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaHTTPError" /> class.
        /// </summary>
        public BetaHTTPError()
        {
        }

    }
}