
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Structured information describing a generated video job.
    /// </summary>
    public sealed partial class VideoResource
    {
        /// <summary>
        /// Unique identifier for the video job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `video`.<br/>
        /// Default Value: video
        /// </summary>
        /// <default>global::tryAGI.OpenAI.VideoResourceObject.Video</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VideoResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.VideoResourceObject Object { get; set; } = global::tryAGI.OpenAI.VideoResourceObject.Video;

        /// <summary>
        /// The video generation model that produced the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VideoModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.VideoModel Model { get; set; }

        /// <summary>
        /// Current lifecycle status of the video job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VideoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.VideoStatus Status { get; set; }

        /// <summary>
        /// Approximate completion percentage for the generation task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Progress { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) for when the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The resolution of the generated video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VideoSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.VideoSize Size { get; set; }

        /// <summary>
        /// Duration of the generated clip in seconds. For extensions, this is the stitched total duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Seconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remixed_from_video_id")]
        public string? RemixedFromVideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.OpenAI.Error2? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the video job.
        /// </param>
        /// <param name="model">
        /// The video generation model that produced the job.
        /// </param>
        /// <param name="status">
        /// Current lifecycle status of the video job.
        /// </param>
        /// <param name="progress">
        /// Approximate completion percentage for the generation task.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (seconds) for when the job was created.
        /// </param>
        /// <param name="size">
        /// The resolution of the generated video.
        /// </param>
        /// <param name="seconds">
        /// Duration of the generated clip in seconds. For extensions, this is the stitched total duration.
        /// </param>
        /// <param name="completedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="prompt"></param>
        /// <param name="remixedFromVideoId"></param>
        /// <param name="error"></param>
        /// <param name="object">
        /// The object type, which is always `video`.<br/>
        /// Default Value: video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoResource(
            string id,
            global::tryAGI.OpenAI.VideoModel model,
            global::tryAGI.OpenAI.VideoStatus status,
            int progress,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.VideoSize size,
            string seconds,
            global::System.DateTimeOffset? completedAt,
            global::System.DateTimeOffset? expiresAt,
            string? prompt,
            string? remixedFromVideoId,
            global::tryAGI.OpenAI.Error2? error,
            global::tryAGI.OpenAI.VideoResourceObject @object = global::tryAGI.OpenAI.VideoResourceObject.Video)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Model = model;
            this.Status = status;
            this.Progress = progress;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.ExpiresAt = expiresAt;
            this.Prompt = prompt;
            this.Size = size;
            this.Seconds = seconds ?? throw new global::System.ArgumentNullException(nameof(seconds));
            this.RemixedFromVideoId = remixedFromVideoId;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResource" /> class.
        /// </summary>
        public VideoResource()
        {
        }
    }
}