
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A summary text from the model.
    /// </summary>
    public sealed partial class Summary
    {
        /// <summary>
        /// A summary of the reasoning output from the model so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of the object. Always `summary_text`.<br/>
        /// Default Value: summary_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SummaryType.SummaryText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SummaryTypeJsonConverter))]
        public global::tryAGI.OpenAI.SummaryType Type { get; set; } = global::tryAGI.OpenAI.SummaryType.SummaryText;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Summary" /> class.
        /// </summary>
        /// <param name="text">
        /// A summary of the reasoning output from the model so far.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `summary_text`.<br/>
        /// Default Value: summary_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Summary(
            string text,
            global::tryAGI.OpenAI.SummaryType type = global::tryAGI.OpenAI.SummaryType.SummaryText)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Summary" /> class.
        /// </summary>
        public Summary()
        {
        }
    }
}