
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Captured stdout and stderr for a portion of a shell tool call output.
    /// </summary>
    public sealed partial class FunctionShellCallOutputContentParam
    {
        /// <summary>
        /// Captured stdout output for the shell call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Stdout { get; set; } = default!;

        /// <summary>
        /// Captured stderr output for the shell call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Stderr { get; set; } = default!;

        /// <summary>
        /// The exit or timeout outcome associated with this shell call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputOutcomeParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam Outcome { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellCallOutputContentParam" /> class.
        /// </summary>
        /// <param name="stdout">
        /// Captured stdout output for the shell call.
        /// </param>
        /// <param name="stderr">
        /// Captured stderr output for the shell call.
        /// </param>
        /// <param name="outcome">
        /// The exit or timeout outcome associated with this shell call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionShellCallOutputContentParam(
            string stdout,
            string stderr,
            global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam outcome)
        {
            this.Stdout = stdout ?? throw new global::System.ArgumentNullException(nameof(stdout));
            this.Stderr = stderr ?? throw new global::System.ArgumentNullException(nameof(stderr));
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellCallOutputContentParam" /> class.
        /// </summary>
        public FunctionShellCallOutputContentParam()
        {
        }
    }
}