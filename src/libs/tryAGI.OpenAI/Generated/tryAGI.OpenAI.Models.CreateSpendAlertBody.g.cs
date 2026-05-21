
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for creating or updating a spend alert.
    /// </summary>
    public sealed partial class CreateSpendAlertBody
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpendAlertBodyCurrencyJsonConverter))]
        public global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency Currency { get; set; }

        /// <summary>
        /// The time interval for evaluating spend against the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateSpendAlertBodyIntervalJsonConverter))]
        public global::tryAGI.OpenAI.CreateSpendAlertBodyInterval Interval { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateSpendAlertBody" /> class.
        /// </summary>
        /// <param name="thresholdAmount">
        /// The alert threshold amount, in cents.
        /// </param>
        /// <param name="notificationChannel">
        /// Email notification settings for a spend alert.
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
        public CreateSpendAlertBody(
            int thresholdAmount,
            global::tryAGI.OpenAI.SpendAlertNotificationChannel notificationChannel,
            global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency currency,
            global::tryAGI.OpenAI.CreateSpendAlertBodyInterval interval)
        {
            this.ThresholdAmount = thresholdAmount;
            this.Currency = currency;
            this.Interval = interval;
            this.NotificationChannel = notificationChannel ?? throw new global::System.ArgumentNullException(nameof(notificationChannel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpendAlertBody" /> class.
        /// </summary>
        public CreateSpendAlertBody()
        {
        }

    }
}