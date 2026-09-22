
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Runs the agent without an execution environment.
    /// </summary>
    public sealed partial class EnvironmentParamNone
    {
        /// <summary>
        /// The type of the object. Always `none`.<br/>
        /// Default Value: none
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EnvironmentParamNoneType.None</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentParamNoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.EnvironmentParamNoneType Type { get; set; } = global::tryAGI.OpenAI.EnvironmentParamNoneType.None;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentParamNone" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `none`.<br/>
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentParamNone(
            global::tryAGI.OpenAI.EnvironmentParamNoneType type = global::tryAGI.OpenAI.EnvironmentParamNoneType.None)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentParamNone" /> class.
        /// </summary>
        public EnvironmentParamNone()
        {
        }

    }
}