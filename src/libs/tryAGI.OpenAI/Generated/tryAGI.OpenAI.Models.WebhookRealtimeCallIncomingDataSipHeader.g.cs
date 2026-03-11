
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A header from the SIP Invite.
    /// </summary>
    public sealed partial class WebhookRealtimeCallIncomingDataSipHeader
    {
        /// <summary>
        /// Name of the SIP Header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Value of the SIP Header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRealtimeCallIncomingDataSipHeader" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the SIP Header.
        /// </param>
        /// <param name="value">
        /// Value of the SIP Header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRealtimeCallIncomingDataSipHeader(
            string name,
            string value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRealtimeCallIncomingDataSipHeader" /> class.
        /// </summary>
        public WebhookRealtimeCallIncomingDataSipHeader()
        {
        }
    }
}