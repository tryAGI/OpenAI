
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains the tools available to the model to a pre-defined set.
    /// </summary>
    public sealed partial class ChatCompletionAllowedToolsChoice
    {
        /// <summary>
        /// Allowed tool configuration type. Always `allowed_tools`.
        /// </summary>
        /// <default>"allowed_tools"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "allowed_tools";

        /// <summary>
        /// Constrains the tools available to the model to a pre-defined set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionAllowedTools AllowedTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAllowedToolsChoice" /> class.
        /// </summary>
        /// <param name="allowedTools">
        /// Constrains the tools available to the model to a pre-defined set.
        /// </param>
        /// <param name="type">
        /// Allowed tool configuration type. Always `allowed_tools`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionAllowedToolsChoice(
            global::tryAGI.OpenAI.ChatCompletionAllowedTools allowedTools,
            string type = "allowed_tools")
        {
            this.Type = type;
            this.AllowedTools = allowedTools ?? throw new global::System.ArgumentNullException(nameof(allowedTools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAllowedToolsChoice" /> class.
        /// </summary>
        public ChatCompletionAllowedToolsChoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionAllowedToolsChoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionAllowedToolsChoice FromAllowedTools(global::tryAGI.OpenAI.ChatCompletionAllowedTools allowedTools)
        {
            return new ChatCompletionAllowedToolsChoice
            {
                AllowedTools = allowedTools,
            };
        }

    }
}