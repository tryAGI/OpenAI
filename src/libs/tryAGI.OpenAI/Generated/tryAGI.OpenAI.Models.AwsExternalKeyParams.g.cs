
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AwsExternalKeyParams
    {
        /// <summary>
        /// A friendly name to identify this config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: aws
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AwsExternalKeyParamsType.Aws</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AwsExternalKeyParamsTypeJsonConverter))]
        public global::tryAGI.OpenAI.AwsExternalKeyParamsType Type { get; set; } = global::tryAGI.OpenAI.AwsExternalKeyParamsType.Aws;

        /// <summary>
        /// The Role ARN that OpenAI will assume to call your KMS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// The Key Management System ARN for the master key you manage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KmsArn { get; set; }

        /// <summary>
        /// The ExternalID that OpenAI will pass in the AssumeRole call for the customer's AWS account. This must be the OpenAI organization ID or an API project ID that belongs to the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ExternalKeyPurposeJsonConverter))]
        public global::tryAGI.OpenAI.ExternalKeyPurpose? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsExternalKeyParams" /> class.
        /// </summary>
        /// <param name="name">
        /// A friendly name to identify this config
        /// </param>
        /// <param name="roleArn">
        /// The Role ARN that OpenAI will assume to call your KMS
        /// </param>
        /// <param name="kmsArn">
        /// The Key Management System ARN for the master key you manage
        /// </param>
        /// <param name="externalId">
        /// The ExternalID that OpenAI will pass in the AssumeRole call for the customer's AWS account. This must be the OpenAI organization ID or an API project ID that belongs to the organization.
        /// </param>
        /// <param name="purpose"></param>
        /// <param name="type">
        /// Default Value: aws
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsExternalKeyParams(
            string name,
            string roleArn,
            string kmsArn,
            string externalId,
            global::tryAGI.OpenAI.ExternalKeyPurpose? purpose,
            global::tryAGI.OpenAI.AwsExternalKeyParamsType type = global::tryAGI.OpenAI.AwsExternalKeyParamsType.Aws)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.KmsArn = kmsArn ?? throw new global::System.ArgumentNullException(nameof(kmsArn));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsExternalKeyParams" /> class.
        /// </summary>
        public AwsExternalKeyParams()
        {
        }

    }
}