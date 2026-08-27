
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaOutputTextContentParam
    {
        /// <summary>
        /// The content type. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaOutputTextContentParamType.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaOutputTextContentParamType Type { get; set; } = global::tryAGI.OpenAI.BetaOutputTextContentParamType.OutputText;

        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Citations associated with the text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem4>? Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOutputTextContentParam" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="annotations">
        /// Citations associated with the text content.
        /// </param>
        /// <param name="type">
        /// The content type. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOutputTextContentParam(
            string text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem4>? annotations,
            global::tryAGI.OpenAI.BetaOutputTextContentParamType type = global::tryAGI.OpenAI.BetaOutputTextContentParamType.OutputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Annotations = annotations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOutputTextContentParam" /> class.
        /// </summary>
        public BetaOutputTextContentParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaOutputTextContentParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaOutputTextContentParam FromText(string text)
        {
            return new BetaOutputTextContentParam
            {
                Text = text,
            };
        }

    }
}