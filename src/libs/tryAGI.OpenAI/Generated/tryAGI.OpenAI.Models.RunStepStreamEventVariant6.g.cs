
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a [run step](https://developers.openai.com/api/docs/assistants/migration) is cancelled.
    /// </summary>
    public sealed partial class RunStepStreamEventVariant6
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread.run.step.cancelled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "thread.run.step.cancelled";

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
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant6" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents a step in execution of a run.
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepStreamEventVariant6(
            global::tryAGI.OpenAI.RunStepObject data,
            string @event = "thread.run.step.cancelled")
        {
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant6" /> class.
        /// </summary>
        public RunStepStreamEventVariant6()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RunStepStreamEventVariant6"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RunStepStreamEventVariant6 FromData(global::tryAGI.OpenAI.RunStepObject data)
        {
            return new RunStepStreamEventVariant6
            {
                Data = data,
            };
        }

    }
}