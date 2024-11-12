
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Specifying a particular function via `{"name": "my_function"}` forces the model to call that function.
    /// </summary>
    public sealed partial class ChatCompletionFunctionCallOption
    {
        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFunctionCallOption" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionFunctionCallOption(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFunctionCallOption" /> class.
        /// </summary>
        public ChatCompletionFunctionCallOption()
        {
        }
    }
}