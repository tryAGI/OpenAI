
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AzureExternalStorageProviderResponse
    {
        /// <summary>
        /// Default Value: azure
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType.Azure</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AzureExternalStorageProviderResponseTypeJsonConverter))]
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType Type { get; set; } = global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType.Azure;

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureExternalStorageProviderResponse" /> class.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="resourceGroup"></param>
        /// <param name="accountName"></param>
        /// <param name="container"></param>
        /// <param name="region"></param>
        /// <param name="type">
        /// Default Value: azure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureExternalStorageProviderResponse(
            string tenantId,
            string subscriptionId,
            string resourceGroup,
            string accountName,
            string container,
            string region,
            global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType type = global::tryAGI.OpenAI.AzureExternalStorageProviderResponseType.Azure)
        {
            this.Type = type;
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.SubscriptionId = subscriptionId ?? throw new global::System.ArgumentNullException(nameof(subscriptionId));
            this.ResourceGroup = resourceGroup ?? throw new global::System.ArgumentNullException(nameof(resourceGroup));
            this.AccountName = accountName ?? throw new global::System.ArgumentNullException(nameof(accountName));
            this.Container = container ?? throw new global::System.ArgumentNullException(nameof(container));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureExternalStorageProviderResponse" /> class.
        /// </summary>
        public AzureExternalStorageProviderResponse()
        {
        }

    }
}