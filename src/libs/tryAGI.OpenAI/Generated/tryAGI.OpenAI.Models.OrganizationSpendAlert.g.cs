
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a spend alert configured at the organization level.
    /// </summary>
    public sealed partial class OrganizationSpendAlert
    {
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `organization.spend_alert`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertObjectJsonConverter))]
        public global::tryAGI.OpenAI.OrganizationSpendAlertObject Object { get; set; }

        /// <summary>
        /// The alert threshold amount, in cents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ThresholdAmount { get; set; }

        /// <summary>
        /// The currency for the threshold amount.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertCurrencyJsonConverter))]
        public global::tryAGI.OpenAI.OrganizationSpendAlertCurrency Currency { get; set; }

        /// <summary>
        /// The time interval for evaluating spend against the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationSpendAlertIntervalJsonConverter))]
        public global::tryAGI.OpenAI.OrganizationSpendAlertInterval Interval { get; set; }

        /// <summary>
        /// Email notification settings for a spend alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SpendAlertNotificationChannel NotificationChannel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSpendAlert" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="thresholdAmount">
        /// The alert threshold amount, in cents.
        /// </param>
        /// <param name="notificationChannel">
        /// Email notification settings for a spend alert.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.spend_alert`.
        /// </param>
        /// <param name="currency">
        /// The currency for the threshold amount.
        /// </param>
        /// <param name="interval">
        /// The time interval for evaluating spend against the threshold.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationSpendAlert(
            string id,
            int thresholdAmount,
            global::tryAGI.OpenAI.SpendAlertNotificationChannel notificationChannel,
            global::tryAGI.OpenAI.OrganizationSpendAlertObject @object,
            global::tryAGI.OpenAI.OrganizationSpendAlertCurrency currency,
            global::tryAGI.OpenAI.OrganizationSpendAlertInterval interval)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.ThresholdAmount = thresholdAmount;
            this.Currency = currency;
            this.Interval = interval;
            this.NotificationChannel = notificationChannel ?? throw new global::System.ArgumentNullException(nameof(notificationChannel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSpendAlert" /> class.
        /// </summary>
        public OrganizationSpendAlert()
        {
        }

    }
}