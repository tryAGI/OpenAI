
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The current enforcement state of a hard spend limit.
    /// </summary>
    public sealed partial class SpendLimitEnforcement
    {
        /// <summary>
        /// Whether the hard spend limit is currently enforcing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SpendLimitEnforcementStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SpendLimitEnforcementStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendLimitEnforcement" /> class.
        /// </summary>
        /// <param name="status">
        /// Whether the hard spend limit is currently enforcing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendLimitEnforcement(
            global::tryAGI.OpenAI.SpendLimitEnforcementStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendLimitEnforcement" /> class.
        /// </summary>
        public SpendLimitEnforcement()
        {
        }

    }
}