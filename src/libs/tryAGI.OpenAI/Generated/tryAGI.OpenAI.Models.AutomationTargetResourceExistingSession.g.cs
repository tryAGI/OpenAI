
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutomationTargetResourceExistingSession
    {
        /// <summary>
        /// The type of the object. Always `existing_session`.<br/>
        /// Default Value: existing_session
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationTargetResourceExistingSessionType.ExistingSession</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationTargetResourceExistingSessionTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationTargetResourceExistingSessionType Type { get; set; } = global::tryAGI.OpenAI.AutomationTargetResourceExistingSessionType.ExistingSession;

        /// <summary>
        /// The session receiving each invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Saved instructions delivered as an automation notification.
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
        /// Initializes a new instance of the <see cref="AutomationTargetResourceExistingSession" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The session receiving each invocation.
        /// </param>
        /// <param name="instructions">
        /// Saved instructions delivered as an automation notification.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `existing_session`.<br/>
        /// Default Value: existing_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationTargetResourceExistingSession(
            string sessionId,
            string instructions,
            global::tryAGI.OpenAI.AutomationTargetResourceExistingSessionType type = global::tryAGI.OpenAI.AutomationTargetResourceExistingSessionType.ExistingSession)
        {
            this.Type = type;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationTargetResourceExistingSession" /> class.
        /// </summary>
        public AutomationTargetResourceExistingSession()
        {
        }

    }
}