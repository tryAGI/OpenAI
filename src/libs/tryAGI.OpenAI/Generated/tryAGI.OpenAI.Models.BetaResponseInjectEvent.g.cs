
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Injects input items into an active response over a WebSocket connection.<br/>
    /// The items are validated and committed atomically. Currently, the server<br/>
    /// accepts client-owned tool outputs that resume a waiting agent.
    /// </summary>
    public sealed partial class BetaResponseInjectEvent
    {
        /// <summary>
        /// The event discriminator. Always `response.inject`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseInjectEventType Type { get; set; }

        /// <summary>
        /// The ID of the active response that should receive the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        /// Input items to inject into the active response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem> Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseInjectEvent" /> class.
        /// </summary>
        /// <param name="responseId">
        /// The ID of the active response that should receive the input.
        /// </param>
        /// <param name="input">
        /// Input items to inject into the active response.
        /// </param>
        /// <param name="type">
        /// The event discriminator. Always `response.inject`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseInjectEvent(
            string responseId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem> input,
            global::tryAGI.OpenAI.BetaResponseInjectEventType type)
        {
            this.Type = type;
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseInjectEvent" /> class.
        /// </summary>
        public BetaResponseInjectEvent()
        {
        }

    }
}