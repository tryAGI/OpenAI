
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2
    {
        /// <summary>
        /// The WebSocket lane that emitted this event. This field is present<br/>
        /// when the originating `response.create` event supplied a<br/>
        /// `stream_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2" /> class.
        /// </summary>
        /// <param name="streamId">
        /// The WebSocket lane that emitted this event. This field is present<br/>
        /// when the originating `response.create` event supplied a<br/>
        /// `stream_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2(
            string? streamId)
        {
            this.StreamId = streamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2" /> class.
        /// </summary>
        public BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2()
        {
        }

    }
}