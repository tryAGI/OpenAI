
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Update the delegation settings of an active Live session. The server acknowledges accepted changes with `session.updated`.<br/>
    /// Example: {"type":"session.update","event_id":"evt_update_001","session":{"delegation":{"type":"responses","responses":{"instructions":"Check restaurant availability. Ask before confirming a booking.","max_output_tokens":1024}}}}
    /// </summary>
    public sealed partial class LiveSessionUpdateParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `session.update`.<br/>
        /// Default Value: session.update
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionUpdateParamType.SessionUpdate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionUpdateParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionUpdateParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionUpdateParamType.SessionUpdate;

        /// <summary>
        /// Sparse delegation updates. Omitted settings retain their values. The delegation type cannot change, including resetting Responses delegation to null or client. Model, frontend instructions, audio, and startup input are immutable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveSessionUpdateParams Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUpdateParam" /> class.
        /// </summary>
        /// <param name="session">
        /// Sparse delegation updates. Omitted settings retain their values. The delegation type cannot change, including resetting Responses delegation to null or client. Model, frontend instructions, audio, and startup input are immutable.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// The Live client event type. Always `session.update`.<br/>
        /// Default Value: session.update
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionUpdateParam(
            global::tryAGI.OpenAI.LiveSessionUpdateParams session,
            string? eventId,
            global::tryAGI.OpenAI.LiveSessionUpdateParamType type = global::tryAGI.OpenAI.LiveSessionUpdateParamType.SessionUpdate)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUpdateParam" /> class.
        /// </summary>
        public LiveSessionUpdateParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveSessionUpdateParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveSessionUpdateParam FromSession(global::tryAGI.OpenAI.LiveSessionUpdateParams session)
        {
            return new LiveSessionUpdateParam
            {
                Session = session,
            };
        }

    }
}