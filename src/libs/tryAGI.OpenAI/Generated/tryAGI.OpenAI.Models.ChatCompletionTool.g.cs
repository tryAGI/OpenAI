
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A function tool that can be used to generate a response.
    /// </summary>
    public sealed partial class ChatCompletionTool
    {
        /// <summary>
        /// The type of the tool. Currently, only `function` is supported.
        /// </summary>
        /// <default>"function"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "function";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FunctionObject Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTool" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type">
        /// The type of the tool. Currently, only `function` is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionTool(
            global::tryAGI.OpenAI.FunctionObject function,
            string type = "function")
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTool" /> class.
        /// </summary>
        public ChatCompletionTool()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionTool"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionTool FromFunction(global::tryAGI.OpenAI.FunctionObject function)
        {
            return new ChatCompletionTool
            {
                Function = function,
            };
        }

    }
}