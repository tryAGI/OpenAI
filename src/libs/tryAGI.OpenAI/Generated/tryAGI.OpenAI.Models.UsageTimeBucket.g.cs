
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageTimeBucket
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketObjectJsonConverter))]
        public global::tryAGI.OpenAI.UsageTimeBucketObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.UsageCompletionsResult, global::tryAGI.OpenAI.UsageEmbeddingsResult, global::tryAGI.OpenAI.UsageModerationsResult, global::tryAGI.OpenAI.UsageImagesResult, global::tryAGI.OpenAI.UsageAudioSpeechesResult, global::tryAGI.OpenAI.UsageAudioTranscriptionsResult, global::tryAGI.OpenAI.UsageVectorStoresResult, global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult, global::tryAGI.OpenAI.CostsResult>> Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimeBucket" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageTimeBucket(
            int startTime,
            int endTime,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.UsageCompletionsResult, global::tryAGI.OpenAI.UsageEmbeddingsResult, global::tryAGI.OpenAI.UsageModerationsResult, global::tryAGI.OpenAI.UsageImagesResult, global::tryAGI.OpenAI.UsageAudioSpeechesResult, global::tryAGI.OpenAI.UsageAudioTranscriptionsResult, global::tryAGI.OpenAI.UsageVectorStoresResult, global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult, global::tryAGI.OpenAI.CostsResult>> result,
            global::tryAGI.OpenAI.UsageTimeBucketObject @object)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimeBucket" /> class.
        /// </summary>
        public UsageTimeBucket()
        {
        }
    }
}