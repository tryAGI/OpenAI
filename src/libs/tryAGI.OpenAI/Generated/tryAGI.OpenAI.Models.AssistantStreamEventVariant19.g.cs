
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) is cancelled.
    /// </summary>
    public sealed partial class AssistantStreamEventVariant19
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AssistantStreamEventVariant19EventJsonConverter))]
        public global::tryAGI.OpenAI.AssistantStreamEventVariant19Event Event { get; set; }

        /// <summary>
        /// Represents a step in execution of a run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunStepObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant19" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a step in execution of a run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantStreamEventVariant19(
            global::tryAGI.OpenAI.RunStepObject data,
            global::tryAGI.OpenAI.AssistantStreamEventVariant19Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant19" /> class.
        /// </summary>
        public AssistantStreamEventVariant19()
        {
        }
    }
}