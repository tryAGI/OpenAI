
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that allows the model to execute shell commands in a local environment.
    /// </summary>
    public sealed partial class LocalShellToolParam
    {
        /// <summary>
        /// The type of the local shell tool. Always `local_shell`.<br/>
        /// Default Value: local_shell
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LocalShellToolParamType.LocalShell</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LocalShellToolParamType Type { get; set; } = global::tryAGI.OpenAI.LocalShellToolParamType.LocalShell;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellToolParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the local shell tool. Always `local_shell`.<br/>
        /// Default Value: local_shell
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalShellToolParam(
            global::tryAGI.OpenAI.LocalShellToolParamType type = global::tryAGI.OpenAI.LocalShellToolParamType.LocalShell)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellToolParam" /> class.
        /// </summary>
        public LocalShellToolParam()
        {
        }
    }
}