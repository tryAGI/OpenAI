
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted after every "response.done" event to indicate the updated rate limits.
    /// </summary>
    public sealed partial class RealtimeRateLimitsUpdated
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_5758
        /// </summary>
        /// <example>event_5758</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "rate_limits.updated".<br/>
        /// Example: rate_limits.updated
        /// </summary>
        /// <example>rate_limits.updated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeRateLimitsUpdatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeRateLimitsUpdatedType? Type { get; set; }

        /// <summary>
        /// List of rate limit information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeRateLimitsUpdatedRateLimit>? RateLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeRateLimitsUpdated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_5758
        /// </param>
        /// <param name="type">
        /// The event type, must be "rate_limits.updated".<br/>
        /// Example: rate_limits.updated
        /// </param>
        /// <param name="rateLimits">
        /// List of rate limit information.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeRateLimitsUpdated(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeRateLimitsUpdatedType? type,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeRateLimitsUpdatedRateLimit>? rateLimits)
        {
            this.EventId = eventId;
            this.Type = type;
            this.RateLimits = rateLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeRateLimitsUpdated" /> class.
        /// </summary>
        public RealtimeRateLimitsUpdated()
        {
        }
    }
}