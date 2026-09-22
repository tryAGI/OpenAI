
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Safe metadata for an inline skill archive.
    /// </summary>
    public sealed partial class HostedTemplateSkillResourceInline
    {
        /// <summary>
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType.Inline</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceInlineTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType Type { get; set; } = global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType.Inline;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedTemplateSkillResourceInline" /> class.
        /// </summary>
        /// <param name="name">
        /// The skill name declared in `SKILL.md`.
        /// </param>
        /// <param name="description">
        /// The skill description declared in `SKILL.md`.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedTemplateSkillResourceInline(
            string name,
            string description,
            global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType type = global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType.Inline)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedTemplateSkillResourceInline" /> class.
        /// </summary>
        public HostedTemplateSkillResourceInline()
        {
        }

    }
}