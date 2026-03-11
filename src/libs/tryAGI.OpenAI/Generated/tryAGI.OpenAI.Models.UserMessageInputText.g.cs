
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text block that a user contributed to the thread.
    /// </summary>
    public sealed partial class UserMessageInputText
    {
        /// <summary>
        /// Type discriminator that is always `input_text`.<br/>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.UserMessageInputTextType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageInputTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.UserMessageInputTextType Type { get; set; } = global::tryAGI.OpenAI.UserMessageInputTextType.InputText;

        /// <summary>
        /// Plain-text content supplied by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageInputText" /> class.
        /// </summary>
        /// <param name="type">
        /// Type discriminator that is always `input_text`.<br/>
        /// Default Value: input_text
        /// </param>
        /// <param name="text">
        /// Plain-text content supplied by the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessageInputText(
            string text,
            global::tryAGI.OpenAI.UserMessageInputTextType type = global::tryAGI.OpenAI.UserMessageInputTextType.InputText)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageInputText" /> class.
        /// </summary>
        public UserMessageInputText()
        {
        }
    }
}