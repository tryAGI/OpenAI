
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Assistant text supplied as conversation history when starting a Live session.
    /// </summary>
    public sealed partial class LiveInitialTextContentPartParam
    {
        /// <summary>
        /// The text content type. Always `text`.<br/>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInitialTextContentPartParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParamType? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="LiveInitialTextContentPartParam" /> class.
        /// </summary>
        /// <param name="text">
        /// The message text to include in the Live session’s initial conversation history.
        /// </param>
        /// <param name="type">
        /// The text content type. Always `text`.<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInitialTextContentPartParam(
            string text,
            global::tryAGI.OpenAI.LiveInitialTextContentPartParamType? type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInitialTextContentPartParam" /> class.
        /// </summary>
        public LiveInitialTextContentPartParam()
        {
        }

    }
}