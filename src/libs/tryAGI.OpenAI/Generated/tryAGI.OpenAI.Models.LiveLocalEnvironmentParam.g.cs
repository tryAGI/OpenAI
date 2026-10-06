
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveLocalEnvironmentParam
    {
        /// <summary>
        /// Use a local computer environment.<br/>
        /// Default Value: local
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveLocalEnvironmentParamType.Local</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveLocalEnvironmentParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParamType Type { get; set; } = global::tryAGI.OpenAI.LiveLocalEnvironmentParamType.Local;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveLocalSkillParam>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveLocalEnvironmentParam" /> class.
        /// </summary>
        /// <param name="skills"></param>
        /// <param name="type">
        /// Use a local computer environment.<br/>
        /// Default Value: local
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveLocalEnvironmentParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveLocalSkillParam>? skills,
            global::tryAGI.OpenAI.LiveLocalEnvironmentParamType type = global::tryAGI.OpenAI.LiveLocalEnvironmentParamType.Local)
        {
            this.Type = type;
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveLocalEnvironmentParam" /> class.
        /// </summary>
        public LiveLocalEnvironmentParam()
        {
        }

    }
}