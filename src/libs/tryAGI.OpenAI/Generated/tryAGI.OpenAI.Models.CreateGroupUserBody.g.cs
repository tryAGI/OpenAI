
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Request payload for adding a user to a group.
    /// </summary>
    public sealed partial class CreateGroupUserBody
    {
        /// <summary>
        /// Identifier of the user to add to the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupUserBody" /> class.
        /// </summary>
        /// <param name="userId">
        /// Identifier of the user to add to the group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGroupUserBody(
            string userId)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupUserBody" /> class.
        /// </summary>
        public CreateGroupUserBody()
        {
        }
    }
}