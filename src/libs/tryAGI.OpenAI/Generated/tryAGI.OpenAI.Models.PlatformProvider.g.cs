
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlatformProvider
    {
        /// <summary>
        /// Default Value: organization.workload_identity_provider
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PlatformProviderObject.OrganizationWorkloadIdentityProvider</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PlatformProviderObjectJsonConverter))]
        public global::tryAGI.OpenAI.PlatformProviderObject Object { get; set; } = global::tryAGI.OpenAI.PlatformProviderObject.OrganizationWorkloadIdentityProvider;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: oidc
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PlatformProviderType.Oidc</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PlatformProviderTypeJsonConverter))]
        public global::tryAGI.OpenAI.PlatformProviderType Type { get; set; } = global::tryAGI.OpenAI.PlatformProviderType.Oidc;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.DiscoveryVerification, global::tryAGI.OpenAI.UploadedJwksVerification>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerification, global::tryAGI.OpenAI.UploadedJwksVerification> Verification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_transformations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Transformation> AttributeTransformations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformProvider" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <param name="verification"></param>
        /// <param name="attributeTransformations"></param>
        /// <param name="enabled"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="object">
        /// Default Value: organization.workload_identity_provider
        /// </param>
        /// <param name="type">
        /// Default Value: oidc
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlatformProvider(
            string id,
            string name,
            string issuer,
            string audience,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerification, global::tryAGI.OpenAI.UploadedJwksVerification> verification,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Transformation> attributeTransformations,
            bool enabled,
            int createdAt,
            int updatedAt,
            string? description,
            global::tryAGI.OpenAI.PlatformProviderObject @object = global::tryAGI.OpenAI.PlatformProviderObject.OrganizationWorkloadIdentityProvider,
            global::tryAGI.OpenAI.PlatformProviderType type = global::tryAGI.OpenAI.PlatformProviderType.Oidc)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Issuer = issuer ?? throw new global::System.ArgumentNullException(nameof(issuer));
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.Verification = verification;
            this.Description = description;
            this.AttributeTransformations = attributeTransformations ?? throw new global::System.ArgumentNullException(nameof(attributeTransformations));
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformProvider" /> class.
        /// </summary>
        public PlatformProvider()
        {
        }

    }
}