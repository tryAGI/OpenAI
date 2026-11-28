
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Unconstrained free-form text.
    /// </summary>
    public sealed partial class CustomToolChatCompletionsCustomFormatTextFormat
    {
        /// <summary>
        /// Unconstrained text format. Always `text`.
        /// </summary>
        /// <default>"text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletionsCustomFormatTextFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Unconstrained text format. Always `text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolChatCompletionsCustomFormatTextFormat(
            string type = "text")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletionsCustomFormatTextFormat" /> class.
        /// </summary>
        public CustomToolChatCompletionsCustomFormatTextFormat()
        {
        }

    }
}