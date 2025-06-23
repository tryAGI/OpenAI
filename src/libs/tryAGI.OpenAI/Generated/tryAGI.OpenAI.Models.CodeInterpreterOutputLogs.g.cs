
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The logs output from the code interpreter.
    /// </summary>
    public sealed partial class CodeInterpreterOutputLogs
    {
        /// <summary>
        /// The type of the output. Always 'logs'.<br/>
        /// Default Value: logs
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CodeInterpreterOutputLogsType.Logs</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputLogsTypeJsonConverter))]
        public global::tryAGI.OpenAI.CodeInterpreterOutputLogsType Type { get; set; } = global::tryAGI.OpenAI.CodeInterpreterOutputLogsType.Logs;

        /// <summary>
        /// The logs output from the code interpreter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterOutputLogs" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the output. Always 'logs'.<br/>
        /// Default Value: logs
        /// </param>
        /// <param name="logs">
        /// The logs output from the code interpreter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterOutputLogs(
            string logs,
            global::tryAGI.OpenAI.CodeInterpreterOutputLogsType type = global::tryAGI.OpenAI.CodeInterpreterOutputLogsType.Logs)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterOutputLogs" /> class.
        /// </summary>
        public CodeInterpreterOutputLogs()
        {
        }
    }
}