
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details about why the response is incomplete.
    /// </summary>
    public sealed partial class BetaResponseVariant3IncompleteDetails2
    {
        /// <summary>
        /// The reason why the response is incomplete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3IncompleteDetailsReasonJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseVariant3IncompleteDetails2" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason why the response is incomplete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseVariant3IncompleteDetails2(
            global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason? reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseVariant3IncompleteDetails2" /> class.
        /// </summary>
        public BetaResponseVariant3IncompleteDetails2()
        {
        }

    }
}