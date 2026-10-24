
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Deliver instructions to an existing session.
    /// </summary>
    public sealed partial class AutomationTargetParamExistingSession
    {
        /// <summary>
        /// The type of the object. Always `existing_session`.<br/>
        /// Default Value: existing_session
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationTargetParamExistingSessionType.ExistingSession</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationTargetParamExistingSessionTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationTargetParamExistingSessionType Type { get; set; } = global::tryAGI.OpenAI.AutomationTargetParamExistingSessionType.ExistingSession;

        /// <summary>
        /// The session receiving each invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Instructions delivered as an automation notification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationTargetParamExistingSession" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The session receiving each invocation.
        /// </param>
        /// <param name="instructions">
        /// Instructions delivered as an automation notification.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `existing_session`.<br/>
        /// Default Value: existing_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationTargetParamExistingSession(
            string sessionId,
            string instructions,
            global::tryAGI.OpenAI.AutomationTargetParamExistingSessionType type = global::tryAGI.OpenAI.AutomationTargetParamExistingSessionType.ExistingSession)
        {
            this.Type = type;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationTargetParamExistingSession" /> class.
        /// </summary>
        public AutomationTargetParamExistingSession()
        {
        }

    }
}