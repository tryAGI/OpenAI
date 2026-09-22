
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A delta of stdout/stderr emitted while a shell call was running.
    /// </summary>
    public sealed partial class BetaShellCallOutputDelta
    {
        /// <summary>
        /// The stdout delta that was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        public string? Stdout { get; set; }

        /// <summary>
        /// The stderr delta that was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        public string? Stderr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaShellCallOutputDelta" /> class.
        /// </summary>
        /// <param name="stdout">
        /// The stdout delta that was emitted.
        /// </param>
        /// <param name="stderr">
        /// The stderr delta that was emitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaShellCallOutputDelta(
            string? stdout,
            string? stderr)
        {
            this.Stdout = stdout;
            this.Stderr = stderr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaShellCallOutputDelta" /> class.
        /// </summary>
        public BetaShellCallOutputDelta()
        {
        }

    }
}