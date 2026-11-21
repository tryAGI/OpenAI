
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePlatformWorkloadIdentityProviderBody
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdatePlatformWorkloadIdentityProviderBody" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <param name="verification"></param>
        /// <param name="description"></param>
        /// <param name="attributeTransformations"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePlatformWorkloadIdentityProviderBody(
            string? name,
            string? issuer,
            string? audience,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerificationParam, global::tryAGI.OpenAI.UploadedJwksVerificationParam>? verification,
            string? description,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TransformationParam>? attributeTransformations,
            bool? enabled)
        {
            this.Name = name;
            this.Issuer = issuer;
            this.Audience = audience;
            this.Verification = verification;
            this.Description = description;
            this.AttributeTransformations = attributeTransformations;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlatformWorkloadIdentityProviderBody" /> class.
        /// </summary>
        public UpdatePlatformWorkloadIdentityProviderBody()
        {
        }

    }
}