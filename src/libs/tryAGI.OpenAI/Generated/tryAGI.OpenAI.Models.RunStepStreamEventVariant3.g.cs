
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when parts of a [run step](https://developers.openai.com/api/docs/assistants/migration) are being streamed.
    /// </summary>
    public sealed partial class RunStepStreamEventVariant3
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread.run.step.delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "thread.run.step.delta";

        /// <summary>
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunStepDeltaObject Data { get; set; }

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
            string @event = "thread.run.step.delta")
        {
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant3" /> class.
        /// </summary>
        public RunStepStreamEventVariant3()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RunStepStreamEventVariant3"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RunStepStreamEventVariant3 FromData(global::tryAGI.OpenAI.RunStepDeltaObject data)
        {
            return new RunStepStreamEventVariant3
            {
                Data = data,
            };
        }

    }
}