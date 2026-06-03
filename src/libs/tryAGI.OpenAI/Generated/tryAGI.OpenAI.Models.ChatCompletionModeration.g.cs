
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Moderation results or errors for the request input and generated output.
    /// </summary>
    public sealed partial class ChatCompletionModeration
    {
        /// <summary>
        /// Moderation for the request input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Input Input { get; set; }

        /// <summary>
        /// Moderation for the generated output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Output Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionModeration" /> class.
        /// </summary>
        /// <param name="input">
        /// Moderation for the request input.
        /// </param>
        /// <param name="output">
        /// Moderation for the generated output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionModeration(
            global::tryAGI.OpenAI.Input input,
            global::tryAGI.OpenAI.Output output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionModeration" /> class.
        /// </summary>
        public ChatCompletionModeration()
        {
        }

    }
}