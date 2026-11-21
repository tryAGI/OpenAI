
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Options for background execution.
    /// </summary>
    public sealed partial class BetaBackgroundOptionsParam
    {
        /// <summary>
        /// The completion window for background execution. Defaults to `soonest`; `2h` and `8h` select discounted background execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaBackgroundCompletionWindowEnumJsonConverter))]
        public global::tryAGI.OpenAI.BetaBackgroundCompletionWindowEnum? CompletionWindow { get; set; }

        /// <summary>
        /// A customer-provided opaque identifier used to prioritize related background requests. It does not add prior history to the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuation_id")]
        public string? ContinuationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBackgroundOptionsParam" /> class.
        /// </summary>
        /// <param name="completionWindow">
        /// The completion window for background execution. Defaults to `soonest`; `2h` and `8h` select discounted background execution.
        /// </param>
        /// <param name="continuationId">
        /// A customer-provided opaque identifier used to prioritize related background requests. It does not add prior history to the input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBackgroundOptionsParam(
            global::tryAGI.OpenAI.BetaBackgroundCompletionWindowEnum? completionWindow,
            string? continuationId)
        {
            this.CompletionWindow = completionWindow;
            this.ContinuationId = continuationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBackgroundOptionsParam" /> class.
        /// </summary>
        public BetaBackgroundOptionsParam()
        {
        }

    }
}