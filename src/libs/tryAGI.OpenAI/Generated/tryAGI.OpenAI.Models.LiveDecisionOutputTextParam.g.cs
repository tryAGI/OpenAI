
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionOutputTextParam
    {
        /// <summary>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionOutputTextParamType.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionOutputTextParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionOutputTextParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionOutputTextParamType.OutputText;

        /// <summary>
        /// The text content.
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
        /// Initializes a new instance of the <see cref="LiveDecisionOutputTextParam" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="type">
        /// Default Value: output_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionOutputTextParam(
            string text,
            global::tryAGI.OpenAI.LiveDecisionOutputTextParamType type = global::tryAGI.OpenAI.LiveDecisionOutputTextParamType.OutputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionOutputTextParam" /> class.
        /// </summary>
        public LiveDecisionOutputTextParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionOutputTextParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionOutputTextParam FromText(string text)
        {
            return new LiveDecisionOutputTextParam
            {
                Text = text,
            };
        }

    }
}