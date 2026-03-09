
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details of the message creation by the run step.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsMessageCreationObject
    {
        /// <summary>
        /// Always `message_creation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_creation")]
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? MessageCreation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsMessageCreationObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `message_creation`.
        /// </param>
        /// <param name="messageCreation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDeltaStepDetailsMessageCreationObject(
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType type,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? messageCreation)
        {
            this.Type = type;
            this.MessageCreation = messageCreation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsMessageCreationObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsMessageCreationObject()
        {
        }
    }
}