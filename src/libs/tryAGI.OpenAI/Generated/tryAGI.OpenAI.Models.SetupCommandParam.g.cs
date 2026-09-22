
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A confidential setup command executed before the hosted agent starts.
    /// </summary>
    public sealed partial class SetupCommandParam
    {
        /// <summary>
        /// The shell command to execute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        /// The absolute working directory. Defaults to `/workspace`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        public string? Cwd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetupCommandParam" /> class.
        /// </summary>
        /// <param name="command">
        /// The shell command to execute.
        /// </param>
        /// <param name="cwd">
        /// The absolute working directory. Defaults to `/workspace`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetupCommandParam(
            string command,
            string? cwd)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Cwd = cwd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetupCommandParam" /> class.
        /// </summary>
        public SetupCommandParam()
        {
        }

    }
}