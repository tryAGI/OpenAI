
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePlatformWorkloadIdentityProviderBody
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: oidc
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBodyType.Oidc</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreatePlatformWorkloadIdentityProviderBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBodyType Type { get; set; } = global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBodyType.Oidc;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Issuer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.DiscoveryVerificationParam, global::tryAGI.OpenAI.UploadedJwksVerificationParam>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerificationParam, global::tryAGI.OpenAI.UploadedJwksVerificationParam>? Verification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_transformations")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TransformationParam>? AttributeTransformations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlatformWorkloadIdentityProviderBody" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <param name="verification"></param>
        /// <param name="description"></param>
        /// <param name="attributeTransformations"></param>
        /// <param name="enabled"></param>
        /// <param name="type">
        /// Default Value: oidc
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePlatformWorkloadIdentityProviderBody(
            string name,
            string issuer,
            string audience,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerificationParam, global::tryAGI.OpenAI.UploadedJwksVerificationParam>? verification,
            string? description,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TransformationParam>? attributeTransformations,
            bool? enabled,
            global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBodyType type = global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBodyType.Oidc)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Issuer = issuer ?? throw new global::System.ArgumentNullException(nameof(issuer));
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.Verification = verification;
            this.Description = description;
            this.AttributeTransformations = attributeTransformations;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlatformWorkloadIdentityProviderBody" /> class.
        /// </summary>
        public CreatePlatformWorkloadIdentityProviderBody()
        {
        }

    }
}