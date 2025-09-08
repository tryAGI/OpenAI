
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for the client secret expiration. Expiration refers to the time after which<br/>
    /// a client secret will no longer be valid for creating sessions. The session itself may<br/>
    /// continue after that time once started. A secret can be used to create multiple sessions<br/>
    /// until it expires.
    /// </summary>
    public sealed partial class RealtimeCreateClientSecretRequestExpiresAfter
    {
        /// <summary>
        /// The anchor point for the client secret expiration, meaning that `seconds` will be added to the `created_at` time of the client secret to produce an expiration timestamp. Only `created_at` is currently supported.<br/>
        /// Default Value: created_at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretRequestExpiresAfterAnchorJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor? Anchor { get; set; }

        /// <summary>
        /// The number of seconds from the anchor point to the expiration. Select a value between `10` and `7200` (2 hours). This default to 600 seconds (10 minutes) if not specified.<br/>
        /// Default Value: 600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public int? Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCreateClientSecretRequestExpiresAfter" /> class.
        /// </summary>
        /// <param name="anchor">
        /// The anchor point for the client secret expiration, meaning that `seconds` will be added to the `created_at` time of the client secret to produce an expiration timestamp. Only `created_at` is currently supported.<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="seconds">
        /// The number of seconds from the anchor point to the expiration. Select a value between `10` and `7200` (2 hours). This default to 600 seconds (10 minutes) if not specified.<br/>
        /// Default Value: 600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeCreateClientSecretRequestExpiresAfter(
            global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor? anchor,
            int? seconds)
        {
            this.Anchor = anchor;
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCreateClientSecretRequestExpiresAfter" /> class.
        /// </summary>
        public RealtimeCreateClientSecretRequestExpiresAfter()
        {
        }
    }
}