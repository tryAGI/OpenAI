
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Provides ZIP bytes encoded with standard base64.
    /// </summary>
    public sealed partial class InlineCapabilitySourceParamBase64
    {
        /// <summary>
        /// The type of the object. Always `base64`.<br/>
        /// Default Value: base64
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type.Base64</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64TypeJsonConverter))]
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type Type { get; set; } = global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type.Base64;

        /// <summary>
        /// The archive media type, always `application/zip`.<br/>
        /// Default Value: application/zip
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType.ApplicationZip</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64MediaTypeJsonConverter))]
        public global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType MediaType { get; set; } = global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType.ApplicationZip;

        /// <summary>
        /// Standard-base64 encoded ZIP archive bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineCapabilitySourceParamBase64" /> class.
        /// </summary>
        /// <param name="data">
        /// Standard-base64 encoded ZIP archive bytes.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `base64`.<br/>
        /// Default Value: base64
        /// </param>
        /// <param name="mediaType">
        /// The archive media type, always `application/zip`.<br/>
        /// Default Value: application/zip
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineCapabilitySourceParamBase64(
            string data,
            global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type type = global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type.Base64,
            global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType mediaType = global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType.ApplicationZip)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineCapabilitySourceParamBase64" /> class.
        /// </summary>
        public InlineCapabilitySourceParamBase64()
        {
        }

        /// <summary>
        /// Creates a new <see cref="InlineCapabilitySourceParamBase64"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static InlineCapabilitySourceParamBase64 FromData(string data)
        {
            return new InlineCapabilitySourceParamBase64
            {
                Data = data,
            };
        }

    }
}