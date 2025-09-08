
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeBetaServerEventRateLimitsUpdatedRateLimit
    {
        /// <summary>
        /// The maximum allowed value for the rate limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The name of the rate limit (`requests`, `tokens`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventRateLimitsUpdatedRateLimitNameJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimitName? Name { get; set; }

        /// <summary>
        /// The remaining value before the limit is reached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// Seconds until the rate limit resets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_seconds")]
        public double? ResetSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventRateLimitsUpdatedRateLimit" /> class.
        /// </summary>
        /// <param name="limit">
        /// The maximum allowed value for the rate limit.
        /// </param>
        /// <param name="name">
        /// The name of the rate limit (`requests`, `tokens`).
        /// </param>
        /// <param name="remaining">
        /// The remaining value before the limit is reached.
        /// </param>
        /// <param name="resetSeconds">
        /// Seconds until the rate limit resets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaServerEventRateLimitsUpdatedRateLimit(
            int? limit,
            global::tryAGI.OpenAI.RealtimeBetaServerEventRateLimitsUpdatedRateLimitName? name,
            int? remaining,
            double? resetSeconds)
        {
            this.Limit = limit;
            this.Name = name;
            this.Remaining = remaining;
            this.ResetSeconds = resetSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventRateLimitsUpdatedRateLimit" /> class.
        /// </summary>
        public RealtimeBetaServerEventRateLimitsUpdatedRateLimit()
        {
        }
    }
}