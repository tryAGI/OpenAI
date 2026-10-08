
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Session-wide spending control, present only when a limit is configured.
    /// </summary>
    public sealed partial class SessionSpendControlResource
    {
        /// <summary>
        /// The configured positive limit in USD cents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Limit { get; set; }

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
        /// Initializes a new instance of the <see cref="SessionSpendControlResource" /> class.
        /// </summary>
        /// <param name="limit">
        /// The configured positive limit in USD cents.
        /// </param>
        /// <param name="consumed">
        /// Best-effort recorded spend floored to whole USD cents, or null when unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionSpendControlResource(
            long limit,
            int? consumed)
        {
            this.Limit = limit;
            this.Consumed = consumed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSpendControlResource" /> class.
        /// </summary>
        public SessionSpendControlResource()
        {
        }

    }
}