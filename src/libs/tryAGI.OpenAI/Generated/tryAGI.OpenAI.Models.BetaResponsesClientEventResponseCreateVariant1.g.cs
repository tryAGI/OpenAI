
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaResponsesClientEventResponseCreateVariant1
    {
        /// <summary>
        /// The type of the client event. Always `response.create`.
        /// </summary>
        /// <default>"response.create"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "response.create";

        /// <summary>
        /// Whether to generate output for this response. Defaults to true when omitted.<br/>
        /// Set to false to prepare request state without model output; the response<br/>
        /// ID can be used as previous_response_id on a later turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate")]
        public bool? Generate { get; set; }

        /// <summary>
        /// The WebSocket lane for this response. Requests with the same<br/>
        /// `stream_id` are processed FIFO, and events for the response echo the<br/>
        /// same `stream_id`.<br/>
        /// `stream_id` controls routing; `previous_response_id` controls<br/>
        /// conversation lineage, so a new lane can fork from a response created<br/>
        /// on another lane.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponsesClientEventResponseCreateVariant1" /> class.
        /// </summary>
        /// <param name="generate">
        /// Whether to generate output for this response. Defaults to true when omitted.<br/>
        /// Set to false to prepare request state without model output; the response<br/>
        /// ID can be used as previous_response_id on a later turn.
        /// </param>
        /// <param name="streamId">
        /// The WebSocket lane for this response. Requests with the same<br/>
        /// `stream_id` are processed FIFO, and events for the response echo the<br/>
        /// same `stream_id`.<br/>
        /// `stream_id` controls routing; `previous_response_id` controls<br/>
        /// conversation lineage, so a new lane can fork from a response created<br/>
        /// on another lane.
        /// </param>
        /// <param name="type">
        /// The type of the client event. Always `response.create`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponsesClientEventResponseCreateVariant1(
            bool? generate,
            string? streamId,
            string type = "response.create")
        {
            this.Type = type;
            this.Generate = generate;
            this.StreamId = streamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponsesClientEventResponseCreateVariant1" /> class.
        /// </summary>
        public BetaResponsesClientEventResponseCreateVariant1()
        {
        }

    }
}