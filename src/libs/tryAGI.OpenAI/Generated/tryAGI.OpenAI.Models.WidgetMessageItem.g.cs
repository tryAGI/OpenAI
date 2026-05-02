
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Thread item that renders a widget payload.
    /// </summary>
    public sealed partial class WidgetMessageItem
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
        /// <default>global::tryAGI.OpenAI.WidgetMessageItemObject.ChatkitThreadItem</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WidgetMessageItemObjectJsonConverter))]
        public global::tryAGI.OpenAI.WidgetMessageItemObject Object { get; set; } = global::tryAGI.OpenAI.WidgetMessageItemObject.ChatkitThreadItem;

        /// <summary>
        /// Unix timestamp (in seconds) for when the item was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Identifier of the parent thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

        /// <summary>
        /// Type discriminator that is always `chatkit.widget`.<br/>
        /// Default Value: chatkit.widget
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WidgetMessageItemType.ChatkitWidget</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WidgetMessageItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.WidgetMessageItemType Type { get; set; } = global::tryAGI.OpenAI.WidgetMessageItemType.ChatkitWidget;

        /// <summary>
        /// Serialized widget payload rendered in the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Widget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetMessageItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the thread item.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) for when the item was created.
        /// </param>
        /// <param name="threadId">
        /// Identifier of the parent thread.
        /// </param>
        /// <param name="widget">
        /// Serialized widget payload rendered in the UI.
        /// </param>
        /// <param name="object">
        /// Type discriminator that is always `chatkit.thread_item`.<br/>
        /// Default Value: chatkit.thread_item
        /// </param>
        /// <param name="type">
        /// Type discriminator that is always `chatkit.widget`.<br/>
        /// Default Value: chatkit.widget
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetMessageItem(
            string id,
            int createdAt,
            string threadId,
            string widget,
            global::tryAGI.OpenAI.WidgetMessageItemObject @object = global::tryAGI.OpenAI.WidgetMessageItemObject.ChatkitThreadItem,
            global::tryAGI.OpenAI.WidgetMessageItemType type = global::tryAGI.OpenAI.WidgetMessageItemType.ChatkitWidget)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.Type = type;
            this.Widget = widget ?? throw new global::System.ArgumentNullException(nameof(widget));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetMessageItem" /> class.
        /// </summary>
        public WidgetMessageItem()
        {
        }
    }
}