
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaLocalEnvironmentParam
    {
        /// <summary>
        /// Use a local computer environment.<br/>
        /// Default Value: local
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaLocalEnvironmentParamType.Local</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParamType Type { get; set; } = global::tryAGI.OpenAI.BetaLocalEnvironmentParamType.Local;

        /// <summary>
        /// An optional list of skills.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLocalSkillParam>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaLocalEnvironmentParam" /> class.
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
        public BetaLocalEnvironmentParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLocalSkillParam>? skills,
            global::tryAGI.OpenAI.BetaLocalEnvironmentParamType type = global::tryAGI.OpenAI.BetaLocalEnvironmentParamType.Local)
        {
            this.Type = type;
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaLocalEnvironmentParam" /> class.
        /// </summary>
        public BetaLocalEnvironmentParam()
        {
        }

    }
}