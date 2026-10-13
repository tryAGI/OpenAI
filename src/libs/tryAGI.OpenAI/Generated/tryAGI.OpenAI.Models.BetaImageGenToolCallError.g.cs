
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaImageGenToolCallError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// The error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// A description of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Public details for a `moderation_blocked` error, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation_details")]
        public global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetails? ModerationDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaImageGenToolCallError" /> class.
        /// </summary>
        /// <param name="type">
        /// The error type.
        /// </param>
        /// <param name="message">
        /// A description of the error.
        /// </param>
        /// <param name="code"></param>
        /// <param name="param"></param>
        /// <param name="moderationDetails">
        /// Public details for a `moderation_blocked` error, when available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaImageGenToolCallError(
            string type,
            string message,
            string? code,
            string? param,
            global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetails? moderationDetails)
        {
            this.Code = code;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
            this.ModerationDetails = moderationDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaImageGenToolCallError" /> class.
        /// </summary>
        public BetaImageGenToolCallError()
        {
        }

    }
}