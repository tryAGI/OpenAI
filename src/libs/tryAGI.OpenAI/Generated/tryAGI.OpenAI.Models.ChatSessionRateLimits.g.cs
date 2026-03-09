
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Active per-minute request limit for the session.
    /// </summary>
    public sealed partial class ChatSessionRateLimits
    {
        /// <summary>
        /// Maximum allowed requests per one-minute window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_requests_per_1_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxRequestsPer1Minute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionRateLimits" /> class.
        /// </summary>
        /// <param name="maxRequestsPer1Minute">
        /// Maximum allowed requests per one-minute window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSessionRateLimits(
            int maxRequestsPer1Minute)
        {
            this.MaxRequestsPer1Minute = maxRequestsPer1Minute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionRateLimits" /> class.
        /// </summary>
        public ChatSessionRateLimits()
        {
        }
    }
}