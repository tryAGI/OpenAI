
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AwsExternalStorageProviderResponse
    {
        /// <summary>
        /// Default Value: aws
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType.Aws</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AwsExternalStorageProviderResponseTypeJsonConverter))]
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType Type { get; set; } = global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType.Aws;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsExternalStorageProviderResponse" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="region"></param>
        /// <param name="bucket"></param>
        /// <param name="roleArn"></param>
        /// <param name="externalId"></param>
        /// <param name="type">
        /// Default Value: aws
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsExternalStorageProviderResponse(
            string accountId,
            string region,
            string bucket,
            string roleArn,
            string externalId,
            global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType type = global::tryAGI.OpenAI.AwsExternalStorageProviderResponseType.Aws)
        {
            this.Type = type;
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsExternalStorageProviderResponse" /> class.
        /// </summary>
        public AwsExternalStorageProviderResponse()
        {
        }

    }
}