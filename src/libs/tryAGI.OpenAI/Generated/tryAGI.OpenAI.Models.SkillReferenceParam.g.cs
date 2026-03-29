
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkillReferenceParam
    {
        /// <summary>
        /// References a skill created with the /v1/skills endpoint.<br/>
        /// Default Value: skill_reference
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SkillReferenceParamType.SkillReference</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SkillReferenceParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.SkillReferenceParamType Type { get; set; } = global::tryAGI.OpenAI.SkillReferenceParamType.SkillReference;

        /// <summary>
        /// The ID of the referenced skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        /// Optional skill version. Use a positive integer or 'latest'. Omit for default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillReferenceParam" /> class.
        /// </summary>
        /// <param name="skillId">
        /// The ID of the referenced skill.
        /// </param>
        /// <param name="version">
        /// Optional skill version. Use a positive integer or 'latest'. Omit for default.
        /// </param>
        /// <param name="type">
        /// References a skill created with the /v1/skills endpoint.<br/>
        /// Default Value: skill_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillReferenceParam(
            string skillId,
            string? version,
            global::tryAGI.OpenAI.SkillReferenceParamType type = global::tryAGI.OpenAI.SkillReferenceParamType.SkillReference)
        {
            this.Type = type;
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillReferenceParam" /> class.
        /// </summary>
        public SkillReferenceParam()
        {
        }
    }
}