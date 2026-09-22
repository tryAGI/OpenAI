
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supplies a skill ZIP directly in the session request.
    /// </summary>
    public sealed partial class HostedSkillParamInline
    {
        /// <summary>
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedSkillParamInlineType.Inline</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedSkillParamInlineTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedSkillParamInlineType Type { get; set; } = global::tryAGI.OpenAI.HostedSkillParamInlineType.Inline;

        /// <summary>
        /// The skill name declared in `SKILL.md`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The skill description declared in `SKILL.md`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The inline ZIP archive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64 Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedSkillParamInline" /> class.
        /// </summary>
        /// <param name="name">
        /// The skill name declared in `SKILL.md`.
        /// </param>
        /// <param name="description">
        /// The skill description declared in `SKILL.md`.
        /// </param>
        /// <param name="source">
        /// The inline ZIP archive.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedSkillParamInline(
            string name,
            string description,
            global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64 source,
            global::tryAGI.OpenAI.HostedSkillParamInlineType type = global::tryAGI.OpenAI.HostedSkillParamInlineType.Inline)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedSkillParamInline" /> class.
        /// </summary>
        public HostedSkillParamInline()
        {
        }

    }
}