
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Assistant output text supplied as conversation history when starting a Live session.
    /// </summary>
    public sealed partial class LiveInitialOutputTextContentPartParam
    {
        /// <summary>
        /// The text content type. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInitialOutputTextContentPartParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType Type { get; set; } = global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType.OutputText;

        /// <summary>
        /// The message text to include in the Live session’s initial conversation history.
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
        /// Initializes a new instance of the <see cref="LiveInitialOutputTextContentPartParam" /> class.
        /// </summary>
        /// <param name="text">
        /// The message text to include in the Live session’s initial conversation history.
        /// </param>
        /// <param name="type">
        /// The text content type. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInitialOutputTextContentPartParam(
            string text,
            global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType type = global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParamType.OutputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInitialOutputTextContentPartParam" /> class.
        /// </summary>
        public LiveInitialOutputTextContentPartParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveInitialOutputTextContentPartParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveInitialOutputTextContentPartParam FromText(string text)
        {
            return new LiveInitialOutputTextContentPartParam
            {
                Text = text,
            };
        }

    }
}