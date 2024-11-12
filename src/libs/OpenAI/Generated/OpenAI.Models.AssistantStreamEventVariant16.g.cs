
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Occurs when parts of a [run step](/docs/api-reference/run-steps/step-object) are being streamed.
    /// </summary>
    public sealed partial class AssistantStreamEventVariant16
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.AssistantStreamEventVariant16EventJsonConverter))]
        public global::OpenAI.AssistantStreamEventVariant16Event Event { get; set; }

        /// <summary>
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunStepDeltaObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant16" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AssistantStreamEventVariant16(
            global::OpenAI.RunStepDeltaObject data,
            global::OpenAI.AssistantStreamEventVariant16Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant16" /> class.
        /// </summary>
        public AssistantStreamEventVariant16()
        {
        }
    }
}