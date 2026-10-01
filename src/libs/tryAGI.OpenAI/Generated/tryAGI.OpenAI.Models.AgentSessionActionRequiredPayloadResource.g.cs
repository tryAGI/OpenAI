
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSessionActionRequiredPayloadResource
    {
        /// <summary>
        /// The ID of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The action type. Retrieve the session for action details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AgentSessionRequiredActionPayloadResource RequiredAction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionActionRequiredPayloadResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the session.
        /// </param>
        /// <param name="requiredAction">
        /// The action type. Retrieve the session for action details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionActionRequiredPayloadResource(
            string id,
            global::tryAGI.OpenAI.AgentSessionRequiredActionPayloadResource requiredAction)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RequiredAction = requiredAction ?? throw new global::System.ArgumentNullException(nameof(requiredAction));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionActionRequiredPayloadResource" /> class.
        /// </summary>
        public AgentSessionActionRequiredPayloadResource()
        {
        }

    }
}