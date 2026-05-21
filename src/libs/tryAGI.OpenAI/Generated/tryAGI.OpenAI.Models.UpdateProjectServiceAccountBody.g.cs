
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for updating a project service account.
    /// </summary>
    public sealed partial class UpdateProjectServiceAccountBody
    {
        /// <summary>
        /// The updated service account name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The updated service account role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UpdateProjectServiceAccountBodyRoleJsonConverter))]
        public global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectServiceAccountBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The updated service account name.
        /// </param>
        /// <param name="role">
        /// The updated service account role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectServiceAccountBody(
            string? name,
            global::tryAGI.OpenAI.UpdateProjectServiceAccountBodyRole? role)
        {
            this.Name = name;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectServiceAccountBody" /> class.
        /// </summary>
        public UpdateProjectServiceAccountBody()
        {
        }

    }
}