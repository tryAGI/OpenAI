
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UploadedJwksVerification
    {
        /// <summary>
        /// Default Value: uploaded_jwks
        /// </summary>
        /// <default>global::tryAGI.OpenAI.UploadedJwksVerificationType.UploadedJwks</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UploadedJwksVerificationTypeJsonConverter))]
        public global::tryAGI.OpenAI.UploadedJwksVerificationType Type { get; set; } = global::tryAGI.OpenAI.UploadedJwksVerificationType.UploadedJwks;

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
        /// Initializes a new instance of the <see cref="UploadedJwksVerification" /> class.
        /// </summary>
        /// <param name="jwks"></param>
        /// <param name="type">
        /// Default Value: uploaded_jwks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadedJwksVerification(
            object jwks,
            global::tryAGI.OpenAI.UploadedJwksVerificationType type = global::tryAGI.OpenAI.UploadedJwksVerificationType.UploadedJwks)
        {
            this.Type = type;
            this.Jwks = jwks ?? throw new global::System.ArgumentNullException(nameof(jwks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedJwksVerification" /> class.
        /// </summary>
        public UploadedJwksVerification()
        {
        }

        /// <summary>
        /// Creates a new <see cref="UploadedJwksVerification"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static UploadedJwksVerification FromJwks(object jwks)
        {
            return new UploadedJwksVerification
            {
                Jwks = jwks,
            };
        }

    }
}