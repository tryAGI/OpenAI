
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A custom tool that processes input using a specified format.
    /// </summary>
    public sealed partial class CustomToolChatCompletions
    {
        /// <summary>
        /// Properties of the custom tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CustomToolChatCompletionsCustom Custom { get; set; }

        /// <summary>
        /// The type of the custom tool. Always `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolChatCompletionsTypeJsonConverter))]
        public global::tryAGI.OpenAI.CustomToolChatCompletionsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletions" /> class.
        /// </summary>
        /// <param name="custom">
        /// Properties of the custom tool.
        /// </param>
        /// <param name="type">
        /// The type of the custom tool. Always `custom`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolChatCompletions(
            global::tryAGI.OpenAI.CustomToolChatCompletionsCustom custom,
            global::tryAGI.OpenAI.CustomToolChatCompletionsType type)
        {
            this.Custom = custom ?? throw new global::System.ArgumentNullException(nameof(custom));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletions" /> class.
        /// </summary>
        public CustomToolChatCompletions()
        {
        }
    }
}