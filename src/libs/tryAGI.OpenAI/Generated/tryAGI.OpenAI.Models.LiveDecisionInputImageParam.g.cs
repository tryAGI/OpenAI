
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionInputImageParam
    {
        /// <summary>
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionInputImageParamType.InputImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionInputImageParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionInputImageParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionInputImageParamType.InputImage;

        /// <summary>
        /// An inline image encoded as a data URL.
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
        /// Initializes a new instance of the <see cref="LiveDecisionInputImageParam" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// An inline image encoded as a data URL.
        /// </param>
        /// <param name="detail"></param>
        /// <param name="type">
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionInputImageParam(
            string imageUrl,
            global::tryAGI.OpenAI.LiveDetailEnum? detail,
            global::tryAGI.OpenAI.LiveDecisionInputImageParamType type = global::tryAGI.OpenAI.LiveDecisionInputImageParamType.InputImage)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionInputImageParam" /> class.
        /// </summary>
        public LiveDecisionInputImageParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionInputImageParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionInputImageParam FromImageUrl(string imageUrl)
        {
            return new LiveDecisionInputImageParam
            {
                ImageUrl = imageUrl,
            };
        }

    }
}