
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Commands and limits describing how to run the shell tool call.
    /// </summary>
    public sealed partial class FunctionShellActionParam
    {
        /// <summary>
        /// Ordered shell commands for the execution environment to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commands")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> Commands { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_length")]
        public int? MaxOutputLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellActionParam" /> class.
        /// </summary>
        /// <param name="commands">
        /// Ordered shell commands for the execution environment to run.
        /// </param>
        /// <param name="timeoutMs"></param>
        /// <param name="maxOutputLength"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionShellActionParam(
            global::System.Collections.Generic.IList<string> commands,
            int? timeoutMs,
            int? maxOutputLength)
        {
            this.Commands = commands ?? throw new global::System.ArgumentNullException(nameof(commands));
            this.TimeoutMs = timeoutMs;
            this.MaxOutputLength = maxOutputLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellActionParam" /> class.
        /// </summary>
        public FunctionShellActionParam()
        {
        }
    }
}