
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Starts an MCP server as a local process.
    /// </summary>
    public sealed partial class PersistedMcpTransportConfigParamStdio
    {
        /// <summary>
        /// The type of the object. Always `stdio`.<br/>
        /// Default Value: stdio
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType.Stdio</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamStdioTypeJsonConverter))]
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType Type { get; set; } = global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType.Stdio;

        /// <summary>
        /// The command used to start the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        /// Arguments passed to the MCP server command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// The working directory used to start the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cwd { get; set; }

        /// <summary>
        /// Environment variable names to inherit from the selected execution environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env_vars")]
        public global::System.Collections.Generic.IList<string>? EnvVars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedMcpTransportConfigParamStdio" /> class.
        /// </summary>
        /// <param name="command">
        /// The command used to start the MCP server.
        /// </param>
        /// <param name="cwd">
        /// The working directory used to start the MCP server.
        /// </param>
        /// <param name="args">
        /// Arguments passed to the MCP server command.
        /// </param>
        /// <param name="envVars">
        /// Environment variable names to inherit from the selected execution environment.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `stdio`.<br/>
        /// Default Value: stdio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersistedMcpTransportConfigParamStdio(
            string command,
            string cwd,
            global::System.Collections.Generic.IList<string>? args,
            global::System.Collections.Generic.IList<string>? envVars,
            global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType type = global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType.Stdio)
        {
            this.Type = type;
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Args = args;
            this.Cwd = cwd ?? throw new global::System.ArgumentNullException(nameof(cwd));
            this.EnvVars = envVars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedMcpTransportConfigParamStdio" /> class.
        /// </summary>
        public PersistedMcpTransportConfigParamStdio()
        {
        }

    }
}