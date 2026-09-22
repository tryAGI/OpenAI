
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A command execution produced by the agent.
    /// </summary>
    public sealed partial class CommandExecutionItemResource
    {
        /// <summary>
        /// The item type. Always `command_execution`.<br/>
        /// Default Value: command_execution
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CommandExecutionItemResourceType.CommandExecution</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CommandExecutionItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.CommandExecutionItemResourceType Type { get; set; } = global::tryAGI.OpenAI.CommandExecutionItemResourceType.CommandExecution;

        /// <summary>
        /// The ID of the command execution item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the turn that contains this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The command that was executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        /// The working directory used to execute the command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        public string? Cwd { get; set; }

        /// <summary>
        /// The status of the command execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FunctionCallStatusResource Status { get; set; }

        /// <summary>
        /// The command output, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// The process exit code, if the command completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_code")]
        public long? ExitCode { get; set; }

        /// <summary>
        /// The command duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public long? DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandExecutionItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the command execution item.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="command">
        /// The command that was executed.
        /// </param>
        /// <param name="status">
        /// The status of the command execution.
        /// </param>
        /// <param name="cwd">
        /// The working directory used to execute the command.
        /// </param>
        /// <param name="output">
        /// The command output, if available.
        /// </param>
        /// <param name="exitCode">
        /// The process exit code, if the command completed.
        /// </param>
        /// <param name="durationMs">
        /// The command duration in milliseconds.
        /// </param>
        /// <param name="type">
        /// The item type. Always `command_execution`.<br/>
        /// Default Value: command_execution
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommandExecutionItemResource(
            string id,
            string turnId,
            string command,
            global::tryAGI.OpenAI.FunctionCallStatusResource status,
            string? cwd,
            string? output,
            long? exitCode,
            long? durationMs,
            global::tryAGI.OpenAI.CommandExecutionItemResourceType type = global::tryAGI.OpenAI.CommandExecutionItemResourceType.CommandExecution)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Cwd = cwd;
            this.Status = status;
            this.Output = output;
            this.ExitCode = exitCode;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandExecutionItemResource" /> class.
        /// </summary>
        public CommandExecutionItemResource()
        {
        }

    }
}