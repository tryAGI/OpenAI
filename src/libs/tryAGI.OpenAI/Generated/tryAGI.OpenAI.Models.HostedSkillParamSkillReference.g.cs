
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// References a skill uploaded through the Skills API.
    /// </summary>
    public sealed partial class HostedSkillParamSkillReference
    {
        /// <summary>
        /// The type of the object. Always `skill_reference`.<br/>
        /// Default Value: skill_reference
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType.SkillReference</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedSkillParamSkillReferenceTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType Type { get; set; } = global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType.SkillReference;

        /// <summary>
        /// The ID of the skill created through `/v1/skills`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        /// The skill version, a positive integer or `latest`; omission selects the default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedSkillParamSkillReference" /> class.
        /// </summary>
        /// <param name="skillId">
        /// The ID of the skill created through `/v1/skills`.
        /// </param>
        /// <param name="version">
        /// The skill version, a positive integer or `latest`; omission selects the default.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `skill_reference`.<br/>
        /// Default Value: skill_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedSkillParamSkillReference(
            string skillId,
            string? version,
            global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType type = global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType.SkillReference)
        {
            this.Type = type;
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedSkillParamSkillReference" /> class.
        /// </summary>
        public HostedSkillParamSkillReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="HostedSkillParamSkillReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static HostedSkillParamSkillReference FromSkillId(string skillId)
        {
            return new HostedSkillParamSkillReference
            {
                SkillId = skillId,
            };
        }

    }
}