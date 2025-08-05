
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaContentTextObjectText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TextAnnotationDelta>? Annotations { get; set; }

        /// <summary>
        /// The data that makes up the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextObjectText" /> class.
        /// </summary>
        /// <param name="annotations"></param>
        /// <param name="value">
        /// The data that makes up the text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaContentTextObjectText(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TextAnnotationDelta>? annotations,
            string? value)
        {
            this.Annotations = annotations;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextObjectText" /> class.
        /// </summary>
        public MessageDeltaContentTextObjectText()
        {
        }
    }
}