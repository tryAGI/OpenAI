
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Task emitted by the workflow to show progress and status updates.
    /// </summary>
    public sealed partial class TaskItem
    {
        /// <summary>
        /// Identifier of the thread item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type discriminator that is always `chatkit.thread_item`.<br/>
        /// Default Value: chatkit.thread_item
        /// </summary>
        /// <default>global::tryAGI.OpenAI.TaskItemObject.ChatkitThreadItem</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TaskItemObjectJsonConverter))]
        public global::tryAGI.OpenAI.TaskItemObject Object { get; set; } = global::tryAGI.OpenAI.TaskItemObject.ChatkitThreadItem;

        /// <summary>
        /// Unix timestamp (in seconds) for when the item was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Identifier of the parent thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

        /// <summary>
        /// Type discriminator that is always `chatkit.task`.<br/>
        /// Default Value: chatkit.task
        /// </summary>
        /// <default>global::tryAGI.OpenAI.TaskItemType.ChatkitTask</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TaskItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.TaskItemType Type { get; set; } = global::tryAGI.OpenAI.TaskItemType.ChatkitTask;

        /// <summary>
        /// Subtype for the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TaskTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.TaskType TaskType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heading")]
        public string? Heading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskItem" /> class.
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
        /// Type discriminator that is always `chatkit.task`.<br/>
        /// Default Value: chatkit.task
        /// </param>
        /// <param name="taskType">
        /// Subtype for the task.
        /// </param>
        /// <param name="heading"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskItem(
            string id,
            global::System.DateTimeOffset createdAt,
            string threadId,
            global::tryAGI.OpenAI.TaskType taskType,
            string? heading,
            string? summary,
            global::tryAGI.OpenAI.TaskItemObject @object = global::tryAGI.OpenAI.TaskItemObject.ChatkitThreadItem,
            global::tryAGI.OpenAI.TaskItemType type = global::tryAGI.OpenAI.TaskItemType.ChatkitTask)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.TaskType = taskType;
            this.Object = @object;
            this.Type = type;
            this.Heading = heading;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskItem" /> class.
        /// </summary>
        public TaskItem()
        {
        }
    }
}