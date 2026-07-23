
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a hard spend limit configured at the organization level.
    /// </summary>
    public sealed partial class OrganizationSpendLimitResource
    {
        /// <summary>
        /// The object type, which is always `organization.spend_limit`.<br/>
        /// Default Value: organization.spend_limit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.OrganizationSpendLimitResourceObject.OrganizationSpendLimit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationSpendLimitResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.OrganizationSpendLimitResourceObject Object { get; set; } = global::tryAGI.OpenAI.OrganizationSpendLimitResourceObject.OrganizationSpendLimit;

        /// <summary>
        /// The hard spend limit amount, in cents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ThresholdAmount { get; set; }

        /// <summary>
        /// The currency for the threshold amount. Currently, only `USD` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SpendLimitCurrencyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SpendLimitCurrency Currency { get; set; }

        /// <summary>
        /// The time interval for evaluating spend against the threshold. Currently, only `month` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SpendLimitIntervalJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SpendLimitInterval Interval { get; set; }

        /// <summary>
        /// The current enforcement state of the hard spend limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SpendLimitEnforcement Enforcement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSpendLimitResource" /> class.
        /// </summary>
        /// <param name="thresholdAmount">
        /// The hard spend limit amount, in cents.
        /// </param>
        /// <param name="currency">
        /// The currency for the threshold amount. Currently, only `USD` is supported.
        /// </param>
        /// <param name="interval">
        /// The time interval for evaluating spend against the threshold. Currently, only `month` is supported.
        /// </param>
        /// <param name="enforcement">
        /// The current enforcement state of the hard spend limit.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.spend_limit`.<br/>
        /// Default Value: organization.spend_limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationSpendLimitResource(
            int thresholdAmount,
            global::tryAGI.OpenAI.SpendLimitCurrency currency,
            global::tryAGI.OpenAI.SpendLimitInterval interval,
            global::tryAGI.OpenAI.SpendLimitEnforcement enforcement,
            global::tryAGI.OpenAI.OrganizationSpendLimitResourceObject @object = global::tryAGI.OpenAI.OrganizationSpendLimitResourceObject.OrganizationSpendLimit)
        {
            this.Object = @object;
            this.ThresholdAmount = thresholdAmount;
            this.Currency = currency;
            this.Interval = interval;
            this.Enforcement = enforcement ?? throw new global::System.ArgumentNullException(nameof(enforcement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSpendLimitResource" /> class.
        /// </summary>
        public OrganizationSpendLimitResource()
        {
        }

    }
}