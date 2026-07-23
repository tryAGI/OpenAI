
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for the hard spend limit you want to create or replace.
    /// </summary>
    public sealed partial class UpdateProjectSpendLimitBody
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UpdateProjectSpendLimitBodyCurrencyJsonConverter))]
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyCurrency Currency { get; set; }

        /// <summary>
        /// The time interval for evaluating spend against the threshold. Currently, only `month` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UpdateProjectSpendLimitBodyIntervalJsonConverter))]
        public global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyInterval Interval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectSpendLimitBody" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectSpendLimitBody(
            int thresholdAmount,
            global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyCurrency currency,
            global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyInterval interval)
        {
            this.ThresholdAmount = thresholdAmount;
            this.Currency = currency;
            this.Interval = interval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectSpendLimitBody" /> class.
        /// </summary>
        public UpdateProjectSpendLimitBody()
        {
        }

    }
}