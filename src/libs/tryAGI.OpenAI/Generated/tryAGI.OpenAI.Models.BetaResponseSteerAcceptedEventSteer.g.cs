
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The accepted steering submission.
    /// </summary>
    public sealed partial class BetaResponseSteerAcceptedEventSteer
    {
        /// <summary>
        /// The ID assigned to the steering submission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the response being steered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousResponseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerAcceptedEventSteer" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID assigned to the steering submission.
        /// </param>
        /// <param name="previousResponseId">
        /// The ID of the response being steered.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseSteerAcceptedEventSteer(
            string id,
            string previousResponseId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PreviousResponseId = previousResponseId ?? throw new global::System.ArgumentNullException(nameof(previousResponseId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerAcceptedEventSteer" /> class.
        /// </summary>
        public BetaResponseSteerAcceptedEventSteer()
        {
        }

    }
}