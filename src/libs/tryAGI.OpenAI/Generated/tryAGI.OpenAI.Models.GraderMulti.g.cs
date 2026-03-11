
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A MultiGrader object combines the output of multiple graders to produce a single score.
    /// </summary>
    public sealed partial class GraderMulti
    {
        /// <summary>
        /// The object type, which is always `multi`.<br/>
        /// Default Value: multi
        /// </summary>
        /// <default>global::tryAGI.OpenAI.GraderMultiType.Multi</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GraderMultiTypeJsonConverter))]
        public global::tryAGI.OpenAI.GraderMultiType Type { get; set; } = global::tryAGI.OpenAI.GraderMultiType.Multi;

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graders")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderLabelModel>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderLabelModel> Graders { get; set; }

        /// <summary>
        /// A formula to calculate the output based on grader results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculate_output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CalculateOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderMulti" /> class.
        /// </summary>
        /// <param name="type">
        /// The object type, which is always `multi`.<br/>
        /// Default Value: multi
        /// </param>
        /// <param name="name">
        /// The name of the grader.
        /// </param>
        /// <param name="graders"></param>
        /// <param name="calculateOutput">
        /// A formula to calculate the output based on grader results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraderMulti(
            string name,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderLabelModel> graders,
            string calculateOutput,
            global::tryAGI.OpenAI.GraderMultiType type = global::tryAGI.OpenAI.GraderMultiType.Multi)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Graders = graders;
            this.CalculateOutput = calculateOutput ?? throw new global::System.ArgumentNullException(nameof(calculateOutput));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderMulti" /> class.
        /// </summary>
        public GraderMulti()
        {
        }
    }
}