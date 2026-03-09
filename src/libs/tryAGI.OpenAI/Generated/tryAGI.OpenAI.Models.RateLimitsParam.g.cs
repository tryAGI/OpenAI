
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls request rate limits for the session.
    /// </summary>
    public sealed partial class RateLimitsParam
    {
        /// <summary>
        /// Maximum number of requests allowed per minute for the session. Defaults to 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_requests_per_1_minute")]
        public int? MaxRequestsPer1Minute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsParam" /> class.
        /// </summary>
        /// <param name="maxRequestsPer1Minute">
        /// Maximum number of requests allowed per minute for the session. Defaults to 10.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitsParam(
            int? maxRequestsPer1Minute)
        {
            this.MaxRequestsPer1Minute = maxRequestsPer1Minute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsParam" /> class.
        /// </summary>
        public RateLimitsParam()
        {
        }
    }
}