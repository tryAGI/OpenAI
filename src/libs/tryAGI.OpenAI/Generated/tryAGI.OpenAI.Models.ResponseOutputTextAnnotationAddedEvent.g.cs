
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when an annotation is added to output text content.
    /// </summary>
    public sealed partial class ResponseOutputTextAnnotationAddedEvent
    {
        /// <summary>
        /// The annotation object being added. (See annotation schema for details.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Annotation { get; set; }

        /// <summary>
        /// The index of the annotation within the content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AnnotationIndex { get; set; }

        /// <summary>
        /// The index of the content part within the output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The unique identifier of the item to which the annotation is being added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The type of the event. Always 'response.output_text.annotation.added'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextAnnotationAddedEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextAnnotationAddedEvent" /> class.
        /// </summary>
        /// <param name="annotation">
        /// The annotation object being added. (See annotation schema for details.)
        /// </param>
        /// <param name="annotationIndex">
        /// The index of the annotation within the content part.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part within the output item.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the item to which the annotation is being added.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always 'response.output_text.annotation.added'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputTextAnnotationAddedEvent(
            object annotation,
            int annotationIndex,
            int contentIndex,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType type)
        {
            this.Annotation = annotation ?? throw new global::System.ArgumentNullException(nameof(annotation));
            this.AnnotationIndex = annotationIndex;
            this.ContentIndex = contentIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextAnnotationAddedEvent" /> class.
        /// </summary>
        public ResponseOutputTextAnnotationAddedEvent()
        {
        }
    }
}