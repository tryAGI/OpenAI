
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sets the session-wide limit without changing recorded spend.
    /// </summary>
    public sealed partial class SessionSpendControlParam
    {
        /// <summary>
        /// Positive USD cents, or null to remove the limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSpendControlParam" /> class.
        /// </summary>
        /// <param name="limit">
        /// Positive USD cents, or null to remove the limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionSpendControlParam(
            long? limit)
        {
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSpendControlParam" /> class.
        /// </summary>
        public SessionSpendControlParam()
        {
        }

    }
}