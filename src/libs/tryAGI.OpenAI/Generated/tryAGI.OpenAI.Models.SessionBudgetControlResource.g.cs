
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Session-wide spending limit and best-effort consumption, including unlimited sessions.
    /// </summary>
    public sealed partial class SessionBudgetControlResource
    {
        /// <summary>
        /// The configured positive limit in USD cents, or null when unlimited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// Best-effort recorded spend floored to whole USD cents, or null when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumed")]
        public int? Consumed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionBudgetControlResource" /> class.
        /// </summary>
        /// <param name="limit">
        /// The configured positive limit in USD cents, or null when unlimited.
        /// </param>
        /// <param name="consumed">
        /// Best-effort recorded spend floored to whole USD cents, or null when unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionBudgetControlResource(
            long? limit,
            int? consumed)
        {
            this.Limit = limit;
            this.Consumed = consumed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionBudgetControlResource" /> class.
        /// </summary>
        public SessionBudgetControlResource()
        {
        }

    }
}