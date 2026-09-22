
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A skill installed from the Skills API.
    /// </summary>
    public sealed partial class HostedSkillResourceSkillReference
    {
        /// <summary>
        /// The type of the object. Always `skill_reference`.<br/>
        /// Default Value: skill_reference
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType.SkillReference</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceSkillReferenceTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType Type { get; set; } = global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType.SkillReference;

        /// <summary>
        /// The referenced skill ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        /// The concrete skill version installed for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// The installed skill name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The installed skill description.
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
        /// Initializes a new instance of the <see cref="HostedSkillResourceSkillReference" /> class.
        /// </summary>
        /// <param name="skillId">
        /// The referenced skill ID.
        /// </param>
        /// <param name="version">
        /// The concrete skill version installed for this session.
        /// </param>
        /// <param name="name">
        /// The installed skill name.
        /// </param>
        /// <param name="description">
        /// The installed skill description.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `skill_reference`.<br/>
        /// Default Value: skill_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedSkillResourceSkillReference(
            string skillId,
            string version,
            string name,
            string description,
            global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType type = global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType.SkillReference)
        {
            this.Type = type;
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedSkillResourceSkillReference" /> class.
        /// </summary>
        public HostedSkillResourceSkillReference()
        {
        }

    }
}