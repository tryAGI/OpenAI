
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteRequestProject
    {
        /// <summary>
        /// Project's public ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Project membership role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InviteRequestProjectRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InviteRequestProjectRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequestProject" /> class.
        /// </summary>
        /// <param name="id">
        /// Project's public ID
        /// </param>
        /// <param name="role">
        /// Project membership role
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public InviteRequestProject(
            string id,
            global::tryAGI.OpenAI.InviteRequestProjectRole role)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequestProject" /> class.
        /// </summary>
        public InviteRequestProject()
        {
        }
    }
}