
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Record of a client side tool invocation initiated by the assistant.
    /// </summary>
    public sealed partial class ClientToolCallItem
    {
        /// <summary>
        /// Identifier of the thread item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Type discriminator that is always `chatkit.thread_item`.<br/>
        /// Default Value: chatkit.thread_item
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ClientToolCallItemObject.ChatkitThreadItem</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ClientToolCallItemObjectJsonConverter))]
        public global::tryAGI.OpenAI.ClientToolCallItemObject Object { get; set; } = global::tryAGI.OpenAI.ClientToolCallItemObject.ChatkitThreadItem;

        /// <summary>
        /// Unix timestamp (in seconds) for when the item was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// Identifier of the parent thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ThreadId { get; set; } = default!;

        /// <summary>
        /// Type discriminator that is always `chatkit.client_tool_call`.<br/>
        /// Default Value: chatkit.client_tool_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ClientToolCallItemType.ChatkitClientToolCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ClientToolCallItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.ClientToolCallItemType Type { get; set; } = global::tryAGI.OpenAI.ClientToolCallItemType.ChatkitClientToolCall;

        /// <summary>
        /// Execution status for the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ClientToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ClientToolCallStatus Status { get; set; } = default!;

        /// <summary>
        /// Identifier for the client tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// Tool name that was invoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// JSON-encoded arguments that were sent to the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolCallItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the thread item.
        /// </param>
        /// <param name="object">
        /// Type discriminator that is always `chatkit.thread_item`.<br/>
        /// Default Value: chatkit.thread_item
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) for when the item was created.
        /// </param>
        /// <param name="threadId">
        /// Identifier of the parent thread.
        /// </param>
        /// <param name="type">
        /// Type discriminator that is always `chatkit.client_tool_call`.<br/>
        /// Default Value: chatkit.client_tool_call
        /// </param>
        /// <param name="status">
        /// Execution status for the tool call.
        /// </param>
        /// <param name="callId">
        /// Identifier for the client tool call.
        /// </param>
        /// <param name="name">
        /// Tool name that was invoked.
        /// </param>
        /// <param name="arguments">
        /// JSON-encoded arguments that were sent to the tool.
        /// </param>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolCallItem(
            string id,
            global::System.DateTimeOffset createdAt,
            string threadId,
            global::tryAGI.OpenAI.ClientToolCallStatus status,
            string callId,
            string name,
            string arguments,
            string? output,
            global::tryAGI.OpenAI.ClientToolCallItemObject @object = global::tryAGI.OpenAI.ClientToolCallItemObject.ChatkitThreadItem,
            global::tryAGI.OpenAI.ClientToolCallItemType type = global::tryAGI.OpenAI.ClientToolCallItemType.ChatkitClientToolCall)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.Status = status;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Object = @object;
            this.Type = type;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolCallItem" /> class.
        /// </summary>
        public ClientToolCallItem()
        {
        }
    }
}