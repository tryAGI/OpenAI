
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Identifies the Live session to observe and control through a sideband WebSocket.
    /// </summary>
    public sealed partial class LiveSidebandPathParams
    {
        /// <summary>
        /// The ID of the existing Live session to attach to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSidebandPathParams" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The ID of the existing Live session to attach to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSidebandPathParams(
            string sessionId)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSidebandPathParams" /> class.
        /// </summary>
        public LiveSidebandPathParams()
        {
        }

    }
}