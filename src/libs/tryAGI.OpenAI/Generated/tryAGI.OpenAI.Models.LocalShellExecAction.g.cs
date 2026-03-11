
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Execute a shell command on the server.
    /// </summary>
    public sealed partial class LocalShellExecAction
    {
        /// <summary>
        /// The type of the local shell action. Always `exec`.<br/>
        /// Default Value: exec
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LocalShellExecActionType.Exec</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellExecActionTypeJsonConverter))]
        public global::tryAGI.OpenAI.LocalShellExecActionType Type { get; set; } = global::tryAGI.OpenAI.LocalShellExecActionType.Exec;

        /// <summary>
        /// The command to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> Command { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("working_directory")]
        public string? WorkingDirectory { get; set; }

        /// <summary>
        /// Environment variables to set for the command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.Dictionary<string, string> Env { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellExecAction" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the local shell action. Always `exec`.<br/>
        /// Default Value: exec
        /// </param>
        /// <param name="command">
        /// The command to run.
        /// </param>
        /// <param name="timeoutMs"></param>
        /// <param name="workingDirectory"></param>
        /// <param name="env">
        /// Environment variables to set for the command.
        /// </param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalShellExecAction(
            global::System.Collections.Generic.IList<string> command,
            global::System.Collections.Generic.Dictionary<string, string> env,
            int? timeoutMs,
            string? workingDirectory,
            string? user,
            global::tryAGI.OpenAI.LocalShellExecActionType type = global::tryAGI.OpenAI.LocalShellExecActionType.Exec)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
            this.Type = type;
            this.TimeoutMs = timeoutMs;
            this.WorkingDirectory = workingDirectory;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellExecAction" /> class.
        /// </summary>
        public LocalShellExecAction()
        {
        }
    }
}