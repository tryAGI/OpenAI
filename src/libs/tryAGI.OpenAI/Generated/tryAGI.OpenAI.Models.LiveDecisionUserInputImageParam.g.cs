
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionUserInputImageParam
    {
        /// <summary>
        /// Default Value: input_image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionUserInputImageParamType.InputImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionUserInputImageParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionUserInputImageParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionUserInputImageParamType.InputImage;

        /// <summary>
        /// A base64-encoded image data URL or a publicly accessible HTTP(S) image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::tryAGI.OpenAI.LiveDetailEnum? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionUserInputImageParam" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// A base64-encoded image data URL or a publicly accessible HTTP(S) image URL.
        /// </param>
        /// <param name="detail"></param>
        /// <param name="type">
        /// Default Value: input_image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionUserInputImageParam(
            string imageUrl,
            global::tryAGI.OpenAI.LiveDetailEnum? detail,
            global::tryAGI.OpenAI.LiveDecisionUserInputImageParamType type = global::tryAGI.OpenAI.LiveDecisionUserInputImageParamType.InputImage)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionUserInputImageParam" /> class.
        /// </summary>
        public LiveDecisionUserInputImageParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionUserInputImageParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionUserInputImageParam FromImageUrl(string imageUrl)
        {
            return new LiveDecisionUserInputImageParam
            {
                ImageUrl = imageUrl,
            };
        }

    }
}