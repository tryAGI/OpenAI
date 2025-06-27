
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when an image generation tool call is actively generating an image (intermediate state).
    /// </summary>
    public sealed partial class ResponseImageGenCallGeneratingEvent
    {
        /// <summary>
        /// The unique identifier of the image generation item being processed.
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
        /// The sequence number of the image generation item being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The type of the event. Always 'response.image_generation_call.generating'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallGeneratingEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseImageGenCallGeneratingEvent" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The unique identifier of the image generation item being processed.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of the image generation item being processed.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always 'response.image_generation_call.generating'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseImageGenCallGeneratingEvent(
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseImageGenCallGeneratingEvent" /> class.
        /// </summary>
        public ResponseImageGenCallGeneratingEvent()
        {
        }
    }
}