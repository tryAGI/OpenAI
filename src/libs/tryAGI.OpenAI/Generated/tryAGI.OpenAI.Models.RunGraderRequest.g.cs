
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunGraderRequest
    {
        /// <summary>
        /// The grader used for the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grader")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti> Grader { get; set; }

        /// <summary>
        /// The dataset item provided to the grader. This will be used to populate <br/>
        /// the `item` namespace. See [the guide](/docs/guides/graders) for more details. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public object? Item { get; set; }

        /// <summary>
        /// The model sample to be evaluated. This value will be used to populate <br/>
        /// the `sample` namespace. See [the guide](/docs/guides/graders) for more details.<br/>
        /// The `output_json` variable will be populated if the model sample is a <br/>
        /// valid JSON string.<br/>
        ///  
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelSample { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderRequest" /> class.
        /// </summary>
        /// <param name="grader">
        /// The grader used for the fine-tuning job.
        /// </param>
        /// <param name="item">
        /// The dataset item provided to the grader. This will be used to populate <br/>
        /// the `item` namespace. See [the guide](/docs/guides/graders) for more details. 
        /// </param>
        /// <param name="modelSample">
        /// The model sample to be evaluated. This value will be used to populate <br/>
        /// the `sample` namespace. See [the guide](/docs/guides/graders) for more details.<br/>
        /// The `output_json` variable will be populated if the model sample is a <br/>
        /// valid JSON string.<br/>
        ///  
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunGraderRequest(
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti> grader,
            string modelSample,
            object? item)
        {
            this.Grader = grader;
            this.ModelSample = modelSample ?? throw new global::System.ArgumentNullException(nameof(modelSample));
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderRequest" /> class.
        /// </summary>
        public RunGraderRequest()
        {
        }
    }
}