
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The SIP transport. Trunk credentials and SDP are not returned.
    /// </summary>
    public sealed partial class LiveSessionCreateResponseTransportVariant2
    {
        /// <summary>
        /// The transport used for the Live session. Always `sip`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionCreateResponseTransportVariant2TypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionCreateResponseTransportVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The transport used for the Live session. Always `sip`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionCreateResponseTransportVariant2(
            global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionCreateResponseTransportVariant2" /> class.
        /// </summary>
        public LiveSessionCreateResponseTransportVariant2()
        {
        }

    }
}