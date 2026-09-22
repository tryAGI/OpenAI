
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The steering submission that could not be committed.
    /// </summary>
    public sealed partial class BetaResponseSteerFailedEventSteer
    {
        /// <summary>
        /// The ID assigned to the steering submission, if one was allocated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the response that was targeted for steering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousResponseId { get; set; }

        /// <summary>
        /// Input to queue for a continuation of the response. Uses the same string or<br/>
        /// input-item shape as `response.create.input`, with a non-empty array when<br/>
        /// supplying input items.<br/>
        /// Steering accepts only messages with the `user` role. Each message may<br/>
        /// contain only `type`, `role`, and `content`, with `content` as a string or an<br/>
        /// array of `input_text`, `input_image`, and `input_file` parts. The optional<br/>
        /// `type` must be `message`. Other roles, tool outputs, and item types are not<br/>
        /// supported for steering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaResponseSteerInput Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerFailedEventSteer" /> class.
        /// </summary>
        /// <param name="previousResponseId">
        /// The ID of the response that was targeted for steering.
        /// </param>
        /// <param name="input">
        /// Input to queue for a continuation of the response. Uses the same string or<br/>
        /// input-item shape as `response.create.input`, with a non-empty array when<br/>
        /// supplying input items.<br/>
        /// Steering accepts only messages with the `user` role. Each message may<br/>
        /// contain only `type`, `role`, and `content`, with `content` as a string or an<br/>
        /// array of `input_text`, `input_image`, and `input_file` parts. The optional<br/>
        /// `type` must be `message`. Other roles, tool outputs, and item types are not<br/>
        /// supported for steering.
        /// </param>
        /// <param name="id">
        /// The ID assigned to the steering submission, if one was allocated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseSteerFailedEventSteer(
            string previousResponseId,
            global::tryAGI.OpenAI.BetaResponseSteerInput input,
            string? id)
        {
            this.Id = id;
            this.PreviousResponseId = previousResponseId ?? throw new global::System.ArgumentNullException(nameof(previousResponseId));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerFailedEventSteer" /> class.
        /// </summary>
        public BetaResponseSteerFailedEventSteer()
        {
        }

    }
}