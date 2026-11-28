
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details of the message creation by the run step.
    /// </summary>
    public sealed partial class RunStepDetailsMessageCreationObject
    {
        /// <summary>
        /// Always `message_creation`.
        /// </summary>
        /// <default>"message_creation"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "message_creation";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation MessageCreation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsMessageCreationObject" /> class.
        /// </summary>
        /// <param name="messageCreation"></param>
        /// <param name="type">
        /// Always `message_creation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDetailsMessageCreationObject(
            global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation messageCreation,
            string type = "message_creation")
        {
            this.Type = type;
            this.MessageCreation = messageCreation ?? throw new global::System.ArgumentNullException(nameof(messageCreation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsMessageCreationObject" /> class.
        /// </summary>
        public RunStepDetailsMessageCreationObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RunStepDetailsMessageCreationObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RunStepDetailsMessageCreationObject FromMessageCreation(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation messageCreation)
        {
            return new RunStepDetailsMessageCreationObject
            {
                MessageCreation = messageCreation,
            };
        }

    }
}