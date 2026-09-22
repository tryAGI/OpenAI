
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A text content part produced by the agent.
    /// </summary>
    public sealed partial class OutputTextResource
    {
        /// <summary>
        /// The content type. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.OutputTextResourceType.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutputTextResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.OutputTextResourceType Type { get; set; } = global::tryAGI.OpenAI.OutputTextResourceType.OutputText;

        /// <summary>
        /// The text produced by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextResource" /> class.
        /// </summary>
        /// <param name="text">
        /// The text produced by the agent.
        /// </param>
        /// <param name="type">
        /// The content type. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputTextResource(
            string text,
            global::tryAGI.OpenAI.OutputTextResourceType type = global::tryAGI.OpenAI.OutputTextResourceType.OutputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextResource" /> class.
        /// </summary>
        public OutputTextResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="OutputTextResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static OutputTextResource FromText(string text)
        {
            return new OutputTextResource
            {
                Text = text,
            };
        }

    }
}