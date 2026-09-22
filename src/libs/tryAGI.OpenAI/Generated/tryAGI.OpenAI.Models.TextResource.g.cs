
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The text configuration used by an agent.
    /// </summary>
    public sealed partial class TextResource
    {
        /// <summary>
        /// The effective output format. Defaults to ordinary text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TextFormatResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.TextFormatResource Format { get; set; }

        /// <summary>
        /// The amount of text produced by the agent. Defaults to `medium`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VerbosityResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.VerbosityResource Verbosity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResource" /> class.
        /// </summary>
        /// <param name="format">
        /// The effective output format. Defaults to ordinary text.
        /// </param>
        /// <param name="verbosity">
        /// The amount of text produced by the agent. Defaults to `medium`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextResource(
            global::tryAGI.OpenAI.TextFormatResource format,
            global::tryAGI.OpenAI.VerbosityResource verbosity)
        {
            this.Format = format;
            this.Verbosity = verbosity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResource" /> class.
        /// </summary>
        public TextResource()
        {
        }

    }
}