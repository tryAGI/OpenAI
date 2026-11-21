
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A custom tool that processes input using a specified format.
    /// </summary>
    public sealed partial class CustomToolChatCompletions
    {
        /// <summary>
        /// The type of the custom tool. Always `custom`.
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// Properties of the custom tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CustomToolChatCompletionsCustom Custom { get; set; }

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
            string type = "custom")
        {
            this.Type = type;
            this.Custom = custom ?? throw new global::System.ArgumentNullException(nameof(custom));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletions" /> class.
        /// </summary>
        public CustomToolChatCompletions()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CustomToolChatCompletions"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CustomToolChatCompletions FromCustom(global::tryAGI.OpenAI.CustomToolChatCompletionsCustom custom)
        {
            return new CustomToolChatCompletions
            {
                Custom = custom,
            };
        }

    }
}