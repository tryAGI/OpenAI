
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunGraderResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunGraderResponseMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_grader_token_usage_per_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ModelGraderTokenUsagePerModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reward")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Reward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_rewards")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object SubRewards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponse" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="modelGraderTokenUsagePerModel"></param>
        /// <param name="reward"></param>
        /// <param name="subRewards"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunGraderResponse(
            global::tryAGI.OpenAI.RunGraderResponseMetadata metadata,
            object modelGraderTokenUsagePerModel,
            double reward,
            object subRewards)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ModelGraderTokenUsagePerModel = modelGraderTokenUsagePerModel ?? throw new global::System.ArgumentNullException(nameof(modelGraderTokenUsagePerModel));
            this.Reward = reward;
            this.SubRewards = subRewards ?? throw new global::System.ArgumentNullException(nameof(subRewards));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponse" /> class.
        /// </summary>
        public RunGraderResponse()
        {
        }
    }
}