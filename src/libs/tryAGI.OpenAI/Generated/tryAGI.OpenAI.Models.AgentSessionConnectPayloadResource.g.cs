
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSessionConnectPayloadResource
    {
        /// <summary>
        /// The URL used to connect the self-hosted environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RemoteUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConnectPayloadResource" /> class.
        /// </summary>
        /// <param name="remoteUrl">
        /// The URL used to connect the self-hosted environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionConnectPayloadResource(
            string remoteUrl)
        {
            this.RemoteUrl = remoteUrl ?? throw new global::System.ArgumentNullException(nameof(remoteUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConnectPayloadResource" /> class.
        /// </summary>
        public AgentSessionConnectPayloadResource()
        {
        }

    }
}