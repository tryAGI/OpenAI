
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A skill installed from an inline ZIP archive.
    /// </summary>
    public sealed partial class HostedSkillResourceInline
    {
        /// <summary>
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedSkillResourceInlineType.Inline</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceInlineTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedSkillResourceInlineType Type { get; set; } = global::tryAGI.OpenAI.HostedSkillResourceInlineType.Inline;

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
        /// Initializes a new instance of the <see cref="HostedSkillResourceInline" /> class.
        /// </summary>
        /// <param name="name">
        /// The installed skill name.
        /// </param>
        /// <param name="description">
        /// The installed skill description.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedSkillResourceInline(
            string name,
            string description,
            global::tryAGI.OpenAI.HostedSkillResourceInlineType type = global::tryAGI.OpenAI.HostedSkillResourceInlineType.Inline)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedSkillResourceInline" /> class.
        /// </summary>
        public HostedSkillResourceInline()
        {
        }

    }
}