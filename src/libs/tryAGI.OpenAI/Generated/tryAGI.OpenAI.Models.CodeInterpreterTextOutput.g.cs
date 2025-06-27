
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output of a code interpreter tool call that is text.
    /// </summary>
    public sealed partial class CodeInterpreterTextOutput
    {
        /// <summary>
        /// The logs of the code interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Logs { get; set; }

        /// <summary>
        /// The type of the code interpreter text output. Always `logs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.CodeInterpreterTextOutputType Type { get; set; }

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
            global::tryAGI.OpenAI.CodeInterpreterTextOutputType type)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterTextOutput" /> class.
        /// </summary>
        public CodeInterpreterTextOutput()
        {
        }
    }
}