
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunGraderResponseMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunGraderResponseMetadataErrors Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExecutionTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampled_model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? SampledModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? TokenUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponseMetadata" /> class.
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="executionTime"></param>
        /// <param name="name"></param>
        /// <param name="sampledModelName"></param>
        /// <param name="scores"></param>
        /// <param name="tokenUsage"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunGraderResponseMetadata(
            global::tryAGI.OpenAI.RunGraderResponseMetadataErrors errors,
            double executionTime,
            string name,
            string? sampledModelName,
            object scores,
            int? tokenUsage,
            string type)
        {
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.ExecutionTime = executionTime;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SampledModelName = sampledModelName ?? throw new global::System.ArgumentNullException(nameof(sampledModelName));
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
            this.TokenUsage = tokenUsage;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponseMetadata" /> class.
        /// </summary>
        public RunGraderResponseMetadata()
        {
        }
    }
}