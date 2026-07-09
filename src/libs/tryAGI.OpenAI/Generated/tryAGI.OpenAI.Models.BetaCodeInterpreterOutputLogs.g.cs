
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The logs output from the code interpreter.
    /// </summary>
    public sealed partial class BetaCodeInterpreterOutputLogs
    {
        /// <summary>
        /// The type of the output. Always `logs`.<br/>
        /// Default Value: logs
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType.Logs</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterOutputLogsTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType Type { get; set; } = global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType.Logs;

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
        /// Initializes a new instance of the <see cref="BetaCodeInterpreterOutputLogs" /> class.
        /// </summary>
        /// <param name="logs">
        /// The logs output from the code interpreter.
        /// </param>
        /// <param name="type">
        /// The type of the output. Always `logs`.<br/>
        /// Default Value: logs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCodeInterpreterOutputLogs(
            string logs,
            global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType type = global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType.Logs)
        {
            this.Type = type;
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCodeInterpreterOutputLogs" /> class.
        /// </summary>
        public BetaCodeInterpreterOutputLogs()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaCodeInterpreterOutputLogs"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaCodeInterpreterOutputLogs FromLogs(string logs)
        {
            return new BetaCodeInterpreterOutputLogs
            {
                Logs = logs,
            };
        }

    }
}