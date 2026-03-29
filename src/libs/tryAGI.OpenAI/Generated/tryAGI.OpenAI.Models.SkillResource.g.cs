
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkillResource
    {
        /// <summary>
        /// Unique identifier for the skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is `skill`.<br/>
        /// Default Value: skill
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SkillResourceObject.Skill</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SkillResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.SkillResourceObject Object { get; set; } = global::tryAGI.OpenAI.SkillResourceObject.Skill;

        /// <summary>
        /// Name of the skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) for when the skill was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Default version for the skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultVersion { get; set; }

        /// <summary>
        /// Latest version for the skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the skill.
        /// </param>
        /// <param name="name">
        /// Name of the skill.
        /// </param>
        /// <param name="description">
        /// Description of the skill.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (seconds) for when the skill was created.
        /// </param>
        /// <param name="defaultVersion">
        /// Default version for the skill.
        /// </param>
        /// <param name="latestVersion">
        /// Latest version for the skill.
        /// </param>
        /// <param name="object">
        /// The object type, which is `skill`.<br/>
        /// Default Value: skill
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillResource(
            string id,
            string name,
            string description,
            global::System.DateTimeOffset createdAt,
            string defaultVersion,
            string latestVersion,
            global::tryAGI.OpenAI.SkillResourceObject @object = global::tryAGI.OpenAI.SkillResourceObject.Skill)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedAt = createdAt;
            this.DefaultVersion = defaultVersion ?? throw new global::System.ArgumentNullException(nameof(defaultVersion));
            this.LatestVersion = latestVersion ?? throw new global::System.ArgumentNullException(nameof(latestVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillResource" /> class.
        /// </summary>
        public SkillResource()
        {
        }
    }
}