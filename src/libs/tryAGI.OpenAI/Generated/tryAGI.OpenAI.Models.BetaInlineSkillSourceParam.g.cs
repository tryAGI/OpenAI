
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Inline skill payload
    /// </summary>
    public sealed partial class BetaInlineSkillSourceParam
    {
        /// <summary>
        /// The type of the inline skill source. Must be `base64`.<br/>
        /// Default Value: base64
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaInlineSkillSourceParamType.Base64</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamType Type { get; set; } = global::tryAGI.OpenAI.BetaInlineSkillSourceParamType.Base64;

        /// <summary>
        /// The media type of the inline skill payload. Must be `application/zip`.<br/>
        /// Default Value: application/zip
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType.ApplicationZip</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamMediaTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType MediaType { get; set; } = global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType.ApplicationZip;

        /// <summary>
        /// Base64-encoded skill zip bundle.
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
        /// Initializes a new instance of the <see cref="BetaInlineSkillSourceParam" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded skill zip bundle.
        /// </param>
        /// <param name="type">
        /// The type of the inline skill source. Must be `base64`.<br/>
        /// Default Value: base64
        /// </param>
        /// <param name="mediaType">
        /// The media type of the inline skill payload. Must be `application/zip`.<br/>
        /// Default Value: application/zip
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInlineSkillSourceParam(
            string data,
            global::tryAGI.OpenAI.BetaInlineSkillSourceParamType type = global::tryAGI.OpenAI.BetaInlineSkillSourceParamType.Base64,
            global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType mediaType = global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType.ApplicationZip)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInlineSkillSourceParam" /> class.
        /// </summary>
        public BetaInlineSkillSourceParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaInlineSkillSourceParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaInlineSkillSourceParam FromData(string data)
        {
            return new BetaInlineSkillSourceParam
            {
                Data = data,
            };
        }

    }
}