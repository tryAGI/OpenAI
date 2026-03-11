
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeletedSkillVersionResource
    {
        /// <summary>
        /// Default Value: skill.version.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedSkillVersionResourceObject.SkillVersionDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedSkillVersionResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedSkillVersionResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedSkillVersionResourceObject.SkillVersionDeleted;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The deleted skill version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedSkillVersionResource" /> class.
        /// </summary>
        /// <param name="object">
        /// Default Value: skill.version.deleted
        /// </param>
        /// <param name="deleted"></param>
        /// <param name="id"></param>
        /// <param name="version">
        /// The deleted skill version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedSkillVersionResource(
            bool deleted,
            string id,
            string version,
            global::tryAGI.OpenAI.DeletedSkillVersionResourceObject @object = global::tryAGI.OpenAI.DeletedSkillVersionResourceObject.SkillVersionDeleted)
        {
            this.Deleted = deleted;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedSkillVersionResource" /> class.
        /// </summary>
        public DeletedSkillVersionResource()
        {
        }
    }
}