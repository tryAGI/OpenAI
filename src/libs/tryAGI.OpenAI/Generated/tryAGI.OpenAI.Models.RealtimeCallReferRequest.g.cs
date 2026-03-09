
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters required to transfer a SIP call to a new destination using the<br/>
    /// Realtime API.
    /// </summary>
    public sealed partial class RealtimeCallReferRequest
    {
        /// <summary>
        /// URI that should appear in the SIP Refer-To header. Supports values like<br/>
        /// `tel:+14155550123` or `sip:agent@example.com`.<br/>
        /// Example: tel:+14155550123
        /// </summary>
        /// <example>tel:+14155550123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCallReferRequest" /> class.
        /// </summary>
        /// <param name="targetUri">
        /// URI that should appear in the SIP Refer-To header. Supports values like<br/>
        /// `tel:+14155550123` or `sip:agent@example.com`.<br/>
        /// Example: tel:+14155550123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeCallReferRequest(
            string targetUri)
        {
            this.TargetUri = targetUri ?? throw new global::System.ArgumentNullException(nameof(targetUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCallReferRequest" /> class.
        /// </summary>
        public RealtimeCallReferRequest()
        {
        }
    }
}