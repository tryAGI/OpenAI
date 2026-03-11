
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content of a shell tool call output that was emitted.
    /// </summary>
    public sealed partial class FunctionShellCallOutputContent
    {
        /// <summary>
        /// The standard output that was captured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stdout { get; set; }

        /// <summary>
        /// The standard error output that was captured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stderr { get; set; }

        /// <summary>
        /// Represents either an exit outcome (with an exit code) or a timeout outcome for a shell call output chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Outcome Outcome { get; set; }

        /// <summary>
        /// The identifier of the actor that created the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellCallOutputContent" /> class.
        /// </summary>
        /// <param name="stdout">
        /// The standard output that was captured.
        /// </param>
        /// <param name="stderr">
        /// The standard error output that was captured.
        /// </param>
        /// <param name="outcome">
        /// Represents either an exit outcome (with an exit code) or a timeout outcome for a shell call output chunk.
        /// </param>
        /// <param name="createdBy">
        /// The identifier of the actor that created the item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionShellCallOutputContent(
            string stdout,
            string stderr,
            global::tryAGI.OpenAI.Outcome outcome,
            string? createdBy)
        {
            this.Stdout = stdout ?? throw new global::System.ArgumentNullException(nameof(stdout));
            this.Stderr = stderr ?? throw new global::System.ArgumentNullException(nameof(stderr));
            this.Outcome = outcome;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionShellCallOutputContent" /> class.
        /// </summary>
        public FunctionShellCallOutputContent()
        {
        }
    }
}