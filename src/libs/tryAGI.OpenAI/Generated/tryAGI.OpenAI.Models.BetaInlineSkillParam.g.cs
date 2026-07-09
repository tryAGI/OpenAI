
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaInlineSkillParam
    {
        /// <summary>
        /// Defines an inline skill for this request.<br/>
        /// Default Value: inline
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaInlineSkillParamType.Inline</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaInlineSkillParamType Type { get; set; } = global::tryAGI.OpenAI.BetaInlineSkillParamType.Inline;

        /// <summary>
        /// The name of the skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Inline skill payload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaInlineSkillSourceParam Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInlineSkillParam" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the skill.
        /// </param>
        /// <param name="description">
        /// The description of the skill.
        /// </param>
        /// <param name="source">
        /// Inline skill payload
        /// </param>
        /// <param name="type">
        /// Defines an inline skill for this request.<br/>
        /// Default Value: inline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInlineSkillParam(
            string name,
            string description,
            global::tryAGI.OpenAI.BetaInlineSkillSourceParam source,
            global::tryAGI.OpenAI.BetaInlineSkillParamType type = global::tryAGI.OpenAI.BetaInlineSkillParamType.Inline)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInlineSkillParam" /> class.
        /// </summary>
        public BetaInlineSkillParam()
        {
        }

    }
}