
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalEnvironmentParam
    {
        /// <summary>
        /// Use a local computer environment.<br/>
        /// Default Value: local
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LocalEnvironmentParamType.Local</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LocalEnvironmentParamType Type { get; set; } = global::tryAGI.OpenAI.LocalEnvironmentParamType.Local;

        /// <summary>
        /// An optional list of skills.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEnvironmentParam" /> class.
        /// </summary>
        /// <param name="skills">
        /// An optional list of skills.
        /// </param>
        /// <param name="type">
        /// Use a local computer environment.<br/>
        /// Default Value: local
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalEnvironmentParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>? skills,
            global::tryAGI.OpenAI.LocalEnvironmentParamType type = global::tryAGI.OpenAI.LocalEnvironmentParamType.Local)
        {
            this.Type = type;
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEnvironmentParam" /> class.
        /// </summary>
        public LocalEnvironmentParam()
        {
        }
    }
}