
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a text annotation is added.
    /// </summary>
    public sealed partial class ResponseTextAnnotationDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `response.output_text.annotation.added`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseTextAnnotationDeltaEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEventType Type { get; set; }

        /// <summary>
        /// The ID of the output item that the text annotation was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that the text annotation was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The index of the content part that the text annotation was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The index of the annotation that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AnnotationIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnnotationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Annotation Annotation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextAnnotationDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.output_text.annotation.added`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the text annotation was added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the text annotation was added to.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part that the text annotation was added to.
        /// </param>
        /// <param name="annotationIndex">
        /// The index of the annotation that was added.
        /// </param>
        /// <param name="annotation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTextAnnotationDeltaEvent(
            string itemId,
            int outputIndex,
            int contentIndex,
            int annotationIndex,
            global::tryAGI.OpenAI.Annotation annotation,
            global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.AnnotationIndex = annotationIndex;
            this.Annotation = annotation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextAnnotationDeltaEvent" /> class.
        /// </summary>
        public ResponseTextAnnotationDeltaEvent()
        {
        }
    }
}