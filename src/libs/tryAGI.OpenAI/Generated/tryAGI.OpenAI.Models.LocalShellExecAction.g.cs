
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Execute a shell command on the server.
    /// </summary>
    public sealed partial class LocalShellExecAction
    {
        /// <summary>
        /// The command to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>
        /// Environment variables to set for the command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Env { get; set; }

        /// <summary>
        /// Optional timeout in milliseconds for the command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// The type of the local shell action. Always `exec`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LocalShellExecActionTypeJsonConverter))]
        public global::tryAGI.OpenAI.LocalShellExecActionType Type { get; set; }

        /// <summary>
        /// Optional user to run the command as.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Optional working directory to run the command in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("working_directory")]
        public string? WorkingDirectory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellExecAction" /> class.
        /// </summary>
        /// <param name="command">
        /// The command to run.
        /// </param>
        /// <param name="env">
        /// Environment variables to set for the command.
        /// </param>
        /// <param name="timeoutMs">
        /// Optional timeout in milliseconds for the command.
        /// </param>
        /// <param name="type">
        /// The type of the local shell action. Always `exec`.
        /// </param>
        /// <param name="user">
        /// Optional user to run the command as.
        /// </param>
        /// <param name="workingDirectory">
        /// Optional working directory to run the command in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalShellExecAction(
            global::System.Collections.Generic.IList<string> command,
            global::System.Collections.Generic.Dictionary<string, string> env,
            int? timeoutMs,
            global::tryAGI.OpenAI.LocalShellExecActionType type,
            string? user,
            string? workingDirectory)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
            this.TimeoutMs = timeoutMs;
            this.Type = type;
            this.User = user;
            this.WorkingDirectory = workingDirectory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellExecAction" /> class.
        /// </summary>
        public LocalShellExecAction()
        {
        }
    }
}