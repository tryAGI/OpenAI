
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ChatCompletionRequestFunctionMessage
    {
        /// <summary>
        /// The role of the messages author, in this case `function`.
        /// </summary>
        /// <default>"function"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string Role { get; set; } = "function";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Content { get; set; }

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestFunctionMessage" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        /// <param name="content"></param>
        /// <param name="role">
        /// The role of the messages author, in this case `function`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestFunctionMessage(
            string name,
            string? content,
            string role = "function")
        {
            this.Role = role;
            this.Content = content;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestFunctionMessage" /> class.
        /// </summary>
        public ChatCompletionRequestFunctionMessage()
        {
        }

    }
}