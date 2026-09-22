
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AzureExternalStorageProviderParams
    {
        /// <summary>
        /// Default Value: azure
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType.Azure</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AzureExternalStorageProviderParamsTypeJsonConverter))]
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType Type { get; set; } = global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType.Azure;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureExternalStorageProviderParams" /> class.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="resourceGroup"></param>
        /// <param name="accountName"></param>
        /// <param name="container"></param>
        /// <param name="type">
        /// Default Value: azure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureExternalStorageProviderParams(
            string tenantId,
            string subscriptionId,
            string resourceGroup,
            string accountName,
            string container,
            global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType type = global::tryAGI.OpenAI.AzureExternalStorageProviderParamsType.Azure)
        {
            this.Type = type;
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.SubscriptionId = subscriptionId ?? throw new global::System.ArgumentNullException(nameof(subscriptionId));
            this.ResourceGroup = resourceGroup ?? throw new global::System.ArgumentNullException(nameof(resourceGroup));
            this.AccountName = accountName ?? throw new global::System.ArgumentNullException(nameof(accountName));
            this.Container = container ?? throw new global::System.ArgumentNullException(nameof(container));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureExternalStorageProviderParams" /> class.
        /// </summary>
        public AzureExternalStorageProviderParams()
        {
        }

    }
}