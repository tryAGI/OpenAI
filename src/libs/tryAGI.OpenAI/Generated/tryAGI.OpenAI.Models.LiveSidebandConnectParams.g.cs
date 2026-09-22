
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Connection options for a sideband WebSocket attached to an existing Live session.
    /// </summary>
    public sealed partial class LiveSidebandConnectParams
    {
        /// <summary>
        /// Opt in to the graceful WebSocket closing handshake when the session ends. The server may also enable this behavior by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graceful_close")]
        public bool? GracefulClose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSidebandConnectParams" /> class.
        /// </summary>
        /// <param name="gracefulClose">
        /// Opt in to the graceful WebSocket closing handshake when the session ends. The server may also enable this behavior by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSidebandConnectParams(
            bool? gracefulClose)
        {
            this.GracefulClose = gracefulClose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSidebandConnectParams" /> class.
        /// </summary>
        public LiveSidebandConnectParams()
        {
        }

    }
}