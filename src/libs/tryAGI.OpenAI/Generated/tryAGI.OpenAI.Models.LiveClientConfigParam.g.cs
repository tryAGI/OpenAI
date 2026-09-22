
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Startup-only capabilities for an untrusted frontend attached to a unified WebRTC session. Trusted sideband connections are unaffected.
    /// </summary>
    public sealed partial class LiveClientConfigParam
    {
        /// <summary>
        /// Client and server event permissions for the WebRTC frontend data channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDataChannelConfigParam DataChannel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveClientConfigParam" /> class.
        /// </summary>
        /// <param name="dataChannel">
        /// Client and server event permissions for the WebRTC frontend data channel.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveClientConfigParam(
            global::tryAGI.OpenAI.LiveDataChannelConfigParam dataChannel)
        {
            this.DataChannel = dataChannel ?? throw new global::System.ArgumentNullException(nameof(dataChannel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveClientConfigParam" /> class.
        /// </summary>
        public LiveClientConfigParam()
        {
        }

    }
}