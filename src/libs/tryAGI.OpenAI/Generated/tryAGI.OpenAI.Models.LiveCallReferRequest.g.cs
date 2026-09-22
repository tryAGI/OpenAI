
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters used to transfer a Live SIP call to another destination.
    /// </summary>
    public sealed partial class LiveCallReferRequest
    {
        /// <summary>
        /// Nonblank URI for the SIP Refer-To header, such as tel:+14155550123 or sip:agent@example.com.<br/>
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
        /// Initializes a new instance of the <see cref="LiveCallReferRequest" /> class.
        /// </summary>
        /// <param name="targetUri">
        /// Nonblank URI for the SIP Refer-To header, such as tel:+14155550123 or sip:agent@example.com.<br/>
        /// Example: tel:+14155550123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveCallReferRequest(
            string targetUri)
        {
            this.TargetUri = targetUri ?? throw new global::System.ArgumentNullException(nameof(targetUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCallReferRequest" /> class.
        /// </summary>
        public LiveCallReferRequest()
        {
        }

    }
}