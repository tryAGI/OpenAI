
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a [run](https://developers.openai.com/api/docs/assistants/migration) moves to an `in_progress` status.
    /// </summary>
    public sealed partial class RunStreamEventVariant3
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread.run.in_progress"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "thread.run.in_progress";

        /// <summary>
        /// Represents an execution run on a [thread](https://developers.openai.com/api/docs/assistants/migration).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamEventVariant3" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents an execution run on a [thread](https://developers.openai.com/api/docs/assistants/migration).
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStreamEventVariant3(
            global::tryAGI.OpenAI.RunObject data,
            string @event = "thread.run.in_progress")
        {
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamEventVariant3" /> class.
        /// </summary>
        public RunStreamEventVariant3()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RunStreamEventVariant3"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RunStreamEventVariant3 FromData(global::tryAGI.OpenAI.RunObject data)
        {
            return new RunStreamEventVariant3
            {
                Data = data,
            };
        }

    }
}