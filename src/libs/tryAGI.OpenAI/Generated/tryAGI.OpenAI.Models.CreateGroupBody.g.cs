
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Request payload for creating a new group in the organization.
    /// </summary>
    public sealed partial class CreateGroupBody
    {
        /// <summary>
        /// Human readable name for the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupBody" /> class.
        /// </summary>
        /// <param name="name">
        /// Human readable name for the group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGroupBody(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupBody" /> class.
        /// </summary>
        public CreateGroupBody()
        {
        }
    }
}