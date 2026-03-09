
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Options to create a new thread. If no thread is provided when running a<br/>
    /// request, an empty thread will be created.
    /// </summary>
    public sealed partial class CreateThreadRequest
    {
        /// <summary>
        /// A list of [messages](/docs/api-reference/messages) to start the thread with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_resources")]
        public global::tryAGI.OpenAI.CreateThreadRequestToolResources2? ToolResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of [messages](/docs/api-reference/messages) to start the thread with.
        /// </param>
        /// <param name="toolResources"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateThreadRequest(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? messages,
            global::tryAGI.OpenAI.CreateThreadRequestToolResources2? toolResources,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Messages = messages;
            this.ToolResources = toolResources;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequest" /> class.
        /// </summary>
        public CreateThreadRequest()
        {
        }
    }
}