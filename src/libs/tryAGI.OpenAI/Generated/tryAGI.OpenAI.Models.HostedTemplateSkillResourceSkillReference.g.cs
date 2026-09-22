
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A skill resolved afresh from the Skills API whenever a session starts.
    /// </summary>
    public sealed partial class HostedTemplateSkillResourceSkillReference
    {
        /// <summary>
        /// The type of the object. Always `skill_reference`.<br/>
        /// Default Value: skill_reference
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType.SkillReference</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceSkillReferenceTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType Type { get; set; } = global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType.SkillReference;

        /// <summary>
        /// The referenced skill ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        /// The requested version selector, including `latest`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedTemplateSkillResourceSkillReference" /> class.
        /// </summary>
        /// <param name="skillId">
        /// The referenced skill ID.
        /// </param>
        /// <param name="version">
        /// The requested version selector, including `latest`.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `skill_reference`.<br/>
        /// Default Value: skill_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedTemplateSkillResourceSkillReference(
            string skillId,
            string? version,
            global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType type = global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType.SkillReference)
        {
            this.Type = type;
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedTemplateSkillResourceSkillReference" /> class.
        /// </summary>
        public HostedTemplateSkillResourceSkillReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="HostedTemplateSkillResourceSkillReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static HostedTemplateSkillResourceSkillReference FromSkillId(string skillId)
        {
            return new HostedTemplateSkillResourceSkillReference
            {
                SkillId = skillId,
            };
        }

    }
}