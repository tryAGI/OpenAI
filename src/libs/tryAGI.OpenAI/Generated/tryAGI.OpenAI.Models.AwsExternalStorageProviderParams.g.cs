
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AwsExternalStorageProviderParams
    {
        /// <summary>
        /// Default Value: aws
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType.Aws</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AwsExternalStorageProviderParamsTypeJsonConverter))]
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType Type { get; set; } = global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType.Aws;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsExternalStorageProviderParams" /> class.
        /// </summary>
        /// <param name="bucket"></param>
        /// <param name="roleArn"></param>
        /// <param name="type">
        /// Default Value: aws
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsExternalStorageProviderParams(
            string bucket,
            string roleArn,
            global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType type = global::tryAGI.OpenAI.AwsExternalStorageProviderParamsType.Aws)
        {
            this.Type = type;
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsExternalStorageProviderParams" /> class.
        /// </summary>
        public AwsExternalStorageProviderParams()
        {
        }

    }
}