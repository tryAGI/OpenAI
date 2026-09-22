
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Changes to an active Live session. Only delegation backend settings can be updated after startup.
    /// </summary>
    public sealed partial class LiveSessionUpdateParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation")]
        public global::tryAGI.OpenAI.DelegationVariant13? Delegation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUpdateParams" /> class.
        /// </summary>
        /// <param name="delegation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionUpdateParams(
            global::tryAGI.OpenAI.DelegationVariant13? delegation)
        {
            this.Delegation = delegation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUpdateParams" /> class.
        /// </summary>
        public LiveSessionUpdateParams()
        {
        }

    }
}