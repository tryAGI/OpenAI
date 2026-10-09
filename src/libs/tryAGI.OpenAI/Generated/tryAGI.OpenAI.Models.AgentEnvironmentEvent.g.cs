
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Identifies the environment whose lifecycle changed.
    /// </summary>
    public sealed partial class AgentEnvironmentEvent
    {
        /// <summary>
        /// The ID of the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEnvironmentEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentEnvironmentEvent(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEnvironmentEvent" /> class.
        /// </summary>
        public AgentEnvironmentEvent()
        {
        }

    }
}