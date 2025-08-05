
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a [run](https://platform.openai.com/docs/api-reference/runs/object) moves to an `in_progress` status.
    /// </summary>
    public sealed partial class RunStreamEventVariant3
    {
        /// <summary>
        /// Represents an execution run on a [thread](https://platform.openai.com/docs/api-reference/threads).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunObject Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant3EventJsonConverter))]
        public global::tryAGI.OpenAI.RunStreamEventVariant3Event Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamEventVariant3" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents an execution run on a [thread](https://platform.openai.com/docs/api-reference/threads).
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStreamEventVariant3(
            global::tryAGI.OpenAI.RunObject data,
            global::tryAGI.OpenAI.RunStreamEventVariant3Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamEventVariant3" /> class.
        /// </summary>
        public RunStreamEventVariant3()
        {
        }
    }
}