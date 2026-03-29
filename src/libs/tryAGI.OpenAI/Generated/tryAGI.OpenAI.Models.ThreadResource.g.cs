
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a ChatKit thread and its current status.<br/>
    /// Example: {"id":"cthr_def456","object":"chatkit.thread","created_at":1712345600,"title":"Demo feedback","status":{"type":"active"},"user":"user_456"}
    /// </summary>
    public sealed partial class ThreadResource
    {
        /// <summary>
        /// Identifier of the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type discriminator that is always `chatkit.thread`.<br/>
        /// Default Value: chatkit.thread
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ThreadResourceObject.ChatkitThread</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ThreadResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ThreadResourceObject Object { get; set; } = global::tryAGI.OpenAI.ThreadResourceObject.ChatkitThread;

        /// <summary>
        /// Unix timestamp (in seconds) for when the thread was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Current status for the thread. Defaults to `active` for newly created threads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Status Status { get; set; }

        /// <summary>
        /// Free-form string that identifies your end user who owns the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the thread.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) for when the thread was created.
        /// </param>
        /// <param name="status">
        /// Current status for the thread. Defaults to `active` for newly created threads.
        /// </param>
        /// <param name="user">
        /// Free-form string that identifies your end user who owns the thread.
        /// </param>
        /// <param name="title"></param>
        /// <param name="object">
        /// Type discriminator that is always `chatkit.thread`.<br/>
        /// Default Value: chatkit.thread
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadResource(
            string id,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.Status status,
            string user,
            string? title,
            global::tryAGI.OpenAI.ThreadResourceObject @object = global::tryAGI.OpenAI.ThreadResourceObject.ChatkitThread)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Title = title;
            this.Status = status;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadResource" /> class.
        /// </summary>
        public ThreadResource()
        {
        }
    }
}