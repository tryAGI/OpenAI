
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UploadedJwksVerificationParam
    {
        /// <summary>
        /// Default Value: uploaded_jwks
        /// </summary>
        /// <default>global::tryAGI.OpenAI.UploadedJwksVerificationParamType.UploadedJwks</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UploadedJwksVerificationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.UploadedJwksVerificationParamType Type { get; set; } = global::tryAGI.OpenAI.UploadedJwksVerificationParamType.UploadedJwks;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Jwks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedJwksVerificationParam" /> class.
        /// </summary>
        /// <param name="jwks"></param>
        /// <param name="type">
        /// Default Value: uploaded_jwks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadedJwksVerificationParam(
            object jwks,
            global::tryAGI.OpenAI.UploadedJwksVerificationParamType type = global::tryAGI.OpenAI.UploadedJwksVerificationParamType.UploadedJwks)
        {
            this.Type = type;
            this.Jwks = jwks ?? throw new global::System.ArgumentNullException(nameof(jwks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedJwksVerificationParam" /> class.
        /// </summary>
        public UploadedJwksVerificationParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="UploadedJwksVerificationParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static UploadedJwksVerificationParam FromJwks(object jwks)
        {
            return new UploadedJwksVerificationParam
            {
                Jwks = jwks,
            };
        }

    }
}