
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when parts of a [run step](/docs/api-reference/run-steps/step-object) are being streamed.
    /// </summary>
    public sealed partial class RunStepStreamEventVariant3
    {
        /// <summary>
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunStepDeltaObject Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant3EventJsonConverter))]
        public global::tryAGI.OpenAI.RunStepStreamEventVariant3Event Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant3" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepStreamEventVariant3(
            global::tryAGI.OpenAI.RunStepDeltaObject data,
            global::tryAGI.OpenAI.RunStepStreamEventVariant3Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant3" /> class.
        /// </summary>
        public RunStepStreamEventVariant3()
        {
        }
    }
}