
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a new [run](https://developers.openai.com/api/docs/assistants/migration) is created.
    /// </summary>
    public sealed partial class RunStreamEventVariant1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread.run.created"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "thread.run.created";

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
        /// Initializes a new instance of the <see cref="RunStreamEventVariant1" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents an execution run on a [thread](https://developers.openai.com/api/docs/assistants/migration).
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStreamEventVariant1(
            global::tryAGI.OpenAI.RunObject data,
            string @event = "thread.run.created")
        {
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamEventVariant1" /> class.
        /// </summary>
        public RunStreamEventVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RunStreamEventVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RunStreamEventVariant1 FromData(global::tryAGI.OpenAI.RunObject data)
        {
            return new RunStreamEventVariant1
            {
                Data = data,
            };
        }

    }
}