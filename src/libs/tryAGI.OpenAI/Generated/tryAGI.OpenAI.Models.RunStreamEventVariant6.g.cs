
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a [run](https://developers.openai.com/api/docs/assistants/migration) ends with status `incomplete`.
    /// </summary>
    public sealed partial class RunStreamEventVariant6
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread.run.incomplete"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "thread.run.incomplete";

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
        /// Initializes a new instance of the <see cref="RunStreamEventVariant6" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents an execution run on a [thread](https://developers.openai.com/api/docs/assistants/migration).
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStreamEventVariant6(
            global::tryAGI.OpenAI.RunObject data,
            string @event = "thread.run.incomplete")
        {
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamEventVariant6" /> class.
        /// </summary>
        public RunStreamEventVariant6()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RunStreamEventVariant6"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RunStreamEventVariant6 FromData(global::tryAGI.OpenAI.RunObject data)
        {
            return new RunStreamEventVariant6
            {
                Data = data,
            };
        }

    }
}