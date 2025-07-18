
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An image generation request made by the model.
    /// </summary>
    public sealed partial class ImageGenToolCall
    {
        /// <summary>
        /// The unique ID of the image generation call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The generated image encoded in base64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Result { get; set; }

        /// <summary>
        /// The status of the image generation call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageGenToolCallStatus Status { get; set; }

        /// <summary>
        /// The type of the image generation call. Always `image_generation_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the image generation call.
        /// </param>
        /// <param name="result">
        /// The generated image encoded in base64.
        /// </param>
        /// <param name="status">
        /// The status of the image generation call.
        /// </param>
        /// <param name="type">
        /// The type of the image generation call. Always `image_generation_call`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenToolCall(
            string id,
            string? result,
            global::tryAGI.OpenAI.ImageGenToolCallStatus status,
            global::tryAGI.OpenAI.ImageGenToolCallType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenToolCall" /> class.
        /// </summary>
        public ImageGenToolCall()
        {
        }
    }
}