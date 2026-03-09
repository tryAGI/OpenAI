
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Execute a shell command.
    /// </summary>
    public sealed partial class FunctionShellAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commands")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Commands { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? TimeoutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? MaxOutputLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellAction" /> class.
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="timeoutMs"></param>
        /// <param name="maxOutputLength"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionShellAction(
            global::System.Collections.Generic.IList<string> commands,
            int? timeoutMs,
            int? maxOutputLength)
        {
            this.Commands = commands ?? throw new global::System.ArgumentNullException(nameof(commands));
            this.TimeoutMs = timeoutMs ?? throw new global::System.ArgumentNullException(nameof(timeoutMs));
            this.MaxOutputLength = maxOutputLength ?? throw new global::System.ArgumentNullException(nameof(maxOutputLength));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellAction" /> class.
        /// </summary>
        public FunctionShellAction()
        {
        }
    }
}