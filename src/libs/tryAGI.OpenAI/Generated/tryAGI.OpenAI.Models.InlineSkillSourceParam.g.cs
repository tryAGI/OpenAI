
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Inline skill payload
    /// </summary>
    public sealed partial class InlineSkillSourceParam
    {
        /// <summary>
        /// The type of the inline skill source. Must be `base64`.<br/>
        /// Default Value: base64
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InlineSkillSourceParamType.Base64</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.InlineSkillSourceParamType Type { get; set; } = global::tryAGI.OpenAI.InlineSkillSourceParamType.Base64;

        /// <summary>
        /// The media type of the inline skill payload. Must be `application/zip`.<br/>
        /// Default Value: application/zip
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InlineSkillSourceParamMediaType.ApplicationDividezip</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamMediaTypeJsonConverter))]
        public global::tryAGI.OpenAI.InlineSkillSourceParamMediaType MediaType { get; set; } = global::tryAGI.OpenAI.InlineSkillSourceParamMediaType.ApplicationDividezip;

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
        /// Initializes a new instance of the <see cref="InlineSkillSourceParam" /> class.
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
        public InlineSkillSourceParam(
            string data,
            global::tryAGI.OpenAI.InlineSkillSourceParamType type = global::tryAGI.OpenAI.InlineSkillSourceParamType.Base64,
            global::tryAGI.OpenAI.InlineSkillSourceParamMediaType mediaType = global::tryAGI.OpenAI.InlineSkillSourceParamMediaType.ApplicationDividezip)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineSkillSourceParam" /> class.
        /// </summary>
        public InlineSkillSourceParam()
        {
        }
    }
}