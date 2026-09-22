
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Accept an incoming SIP call with Live startup configuration.
    /// </summary>
    public sealed partial class LiveCallAcceptRequest
    {
        /// <summary>
        /// Model and startup configuration for the Live session that answers the incoming SIP call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveCallAcceptSession Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCallAcceptRequest" /> class.
        /// </summary>
        /// <param name="session">
        /// Model and startup configuration for the Live session that answers the incoming SIP call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveCallAcceptRequest(
            global::tryAGI.OpenAI.LiveCallAcceptSession session)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCallAcceptRequest" /> class.
        /// </summary>
        public LiveCallAcceptRequest()
        {
        }

    }
}