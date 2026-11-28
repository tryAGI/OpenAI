
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output of a code interpreter tool call that is text.
    /// </summary>
    public sealed partial class CodeInterpreterTextOutput
    {
        /// <summary>
        /// The type of the code interpreter text output. Always `logs`.
        /// </summary>
        /// <default>"logs"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "logs";

        /// <summary>
        /// The logs of the code interpreter tool call.
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
        /// Initializes a new instance of the <see cref="CodeInterpreterTextOutput" /> class.
        /// </summary>
        /// <param name="logs">
        /// The logs of the code interpreter tool call.
        /// </param>
        /// <param name="type">
        /// The type of the code interpreter text output. Always `logs`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterTextOutput(
            string logs,
            string type = "logs")
        {
            this.Type = type;
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterTextOutput" /> class.
        /// </summary>
        public CodeInterpreterTextOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CodeInterpreterTextOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CodeInterpreterTextOutput FromLogs(string logs)
        {
            return new CodeInterpreterTextOutput
            {
                Logs = logs,
            };
        }

    }
}