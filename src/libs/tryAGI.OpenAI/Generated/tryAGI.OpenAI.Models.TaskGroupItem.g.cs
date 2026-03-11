
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Collection of workflow tasks grouped together in the thread.
    /// </summary>
    public sealed partial class TaskGroupItem
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
        /// <default>global::tryAGI.OpenAI.TaskGroupItemObject.ChatkitThreadItem</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TaskGroupItemObjectJsonConverter))]
        public global::tryAGI.OpenAI.TaskGroupItemObject Object { get; set; } = global::tryAGI.OpenAI.TaskGroupItemObject.ChatkitThreadItem;

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
        /// Type discriminator that is always `chatkit.task_group`.<br/>
        /// Default Value: chatkit.task_group
        /// </summary>
        /// <default>global::tryAGI.OpenAI.TaskGroupItemType.ChatkitTaskGroup</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TaskGroupItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.TaskGroupItemType Type { get; set; } = global::tryAGI.OpenAI.TaskGroupItemType.ChatkitTaskGroup;

        /// <summary>
        /// Tasks included in the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TaskGroupTask> Tasks { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskGroupItem" /> class.
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
        /// Type discriminator that is always `chatkit.task_group`.<br/>
        /// Default Value: chatkit.task_group
        /// </param>
        /// <param name="tasks">
        /// Tasks included in the group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskGroupItem(
            string id,
            global::System.DateTimeOffset createdAt,
            string threadId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TaskGroupTask> tasks,
            global::tryAGI.OpenAI.TaskGroupItemObject @object = global::tryAGI.OpenAI.TaskGroupItemObject.ChatkitThreadItem,
            global::tryAGI.OpenAI.TaskGroupItemType type = global::tryAGI.OpenAI.TaskGroupItemType.ChatkitTaskGroup)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskGroupItem" /> class.
        /// </summary>
        public TaskGroupItem()
        {
        }
    }
}