
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentTextObjectText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TextAnnotation> Annotations { get; set; }

        /// <summary>
        /// The data that makes up the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextObjectText" /> class.
        /// </summary>
        /// <param name="annotations"></param>
        /// <param name="value">
        /// The data that makes up the text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentTextObjectText(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TextAnnotation> annotations,
            string value)
        {
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextObjectText" /> class.
        /// </summary>
        public MessageContentTextObjectText()
        {
        }
    }
}