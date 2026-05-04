
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkillVersionResource
    {
        /// <summary>
        /// The object type, which is `skill.version`.<br/>
        /// Default Value: skill.version
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SkillVersionResourceObject.SkillVersion</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SkillVersionResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.SkillVersionResourceObject Object { get; set; } = global::tryAGI.OpenAI.SkillVersionResourceObject.SkillVersion;

        /// <summary>
        /// Unique identifier for the skill version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Identifier of the skill for this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        /// Version number for this skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) for when the version was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Name of the skill version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the skill version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillVersionResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the skill version.
        /// </param>
        /// <param name="skillId">
        /// Identifier of the skill for this version.
        /// </param>
        /// <param name="version">
        /// Version number for this skill.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (seconds) for when the version was created.
        /// </param>
        /// <param name="name">
        /// Name of the skill version.
        /// </param>
        /// <param name="description">
        /// Description of the skill version.
        /// </param>
        /// <param name="object">
        /// The object type, which is `skill.version`.<br/>
        /// Default Value: skill.version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillVersionResource(
            string id,
            string skillId,
            string version,
            int createdAt,
            string name,
            string description,
            global::tryAGI.OpenAI.SkillVersionResourceObject @object = global::tryAGI.OpenAI.SkillVersionResourceObject.SkillVersion)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillVersionResource" /> class.
        /// </summary>
        public SkillVersionResource()
        {
        }
    }
}