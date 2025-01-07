
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeRateLimitsUpdatedRateLimit
    {
        /// <summary>
        /// The name of the rate limit.<br/>
        /// Example: requests
        /// </summary>
        /// <example>requests</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeRateLimitsUpdatedRateLimitNameJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeRateLimitsUpdatedRateLimitName? Name { get; set; }

        /// <summary>
        /// The maximum allowed value for the rate limit.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The remaining value before the limit is reached.<br/>
        /// Example: 999
        /// </summary>
        /// <example>999</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// Seconds until the rate limit resets.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_seconds")]
        public double? ResetSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeRateLimitsUpdatedRateLimit" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the rate limit.<br/>
        /// Example: requests
        /// </param>
        /// <param name="limit">
        /// The maximum allowed value for the rate limit.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="remaining">
        /// The remaining value before the limit is reached.<br/>
        /// Example: 999
        /// </param>
        /// <param name="resetSeconds">
        /// Seconds until the rate limit resets.<br/>
        /// Example: 60
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeRateLimitsUpdatedRateLimit(
            global::tryAGI.OpenAI.RealtimeRateLimitsUpdatedRateLimitName? name,
            int? limit,
            int? remaining,
            double? resetSeconds)
        {
            this.Name = name;
            this.Limit = limit;
            this.Remaining = remaining;
            this.ResetSeconds = resetSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeRateLimitsUpdatedRateLimit" /> class.
        /// </summary>
        public RealtimeRateLimitsUpdatedRateLimit()
        {
        }
    }
}