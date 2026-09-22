
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Input events submitted to an existing session.
    /// </summary>
    public sealed partial class CreateSessionEventsParams
    {
        /// <summary>
        /// The input events to submit to the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionInputParam> Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionEventsParams" /> class.
        /// </summary>
        /// <param name="events">
        /// The input events to submit to the session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionEventsParams(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionInputParam> events)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionEventsParams" /> class.
        /// </summary>
        public CreateSessionEventsParams()
        {
        }

    }
}