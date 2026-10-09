
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsUsageBucket
    {
        /// <summary>
        /// Default Value: bucket
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionsUsageBucketObject.Bucket</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionsUsageBucketObjectJsonConverter))]
        public global::tryAGI.OpenAI.DecisionsUsageBucketObject Object { get; set; } = global::tryAGI.OpenAI.DecisionsUsageBucketObject.Bucket;

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
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsUsageBucket" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="results"></param>
        /// <param name="object">
        /// Default Value: bucket
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsUsageBucket(
            int startTime,
            int endTime,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageResult> results,
            global::tryAGI.OpenAI.DecisionsUsageBucketObject @object = global::tryAGI.OpenAI.DecisionsUsageBucketObject.Bucket)
        {
            this.Object = @object;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsUsageBucket" /> class.
        /// </summary>
        public DecisionsUsageBucket()
        {
        }

    }
}