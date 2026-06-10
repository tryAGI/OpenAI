
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An error produced while attempting moderation for the response input or output.
    /// </summary>
    public sealed partial class ModerationErrorBody
    {
        /// <summary>
        /// The object type, which was always `error` for moderation failures.<br/>
        /// Default Value: error
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ModerationErrorBodyType.Error</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ModerationErrorBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.ModerationErrorBodyType Type { get; set; } = global::tryAGI.OpenAI.ModerationErrorBodyType.Error;

        /// <summary>
        /// The error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The error message.
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
        /// Initializes a new instance of the <see cref="ModerationErrorBody" /> class.
        /// </summary>
        /// <param name="code">
        /// The error code.
        /// </param>
        /// <param name="message">
        /// The error message.
        /// </param>
        /// <param name="type">
        /// The object type, which was always `error` for moderation failures.<br/>
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationErrorBody(
            string code,
            string message,
            global::tryAGI.OpenAI.ModerationErrorBodyType type = global::tryAGI.OpenAI.ModerationErrorBodyType.Error)
        {
            this.Type = type;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationErrorBody" /> class.
        /// </summary>
        public ModerationErrorBody()
        {
        }

    }
}