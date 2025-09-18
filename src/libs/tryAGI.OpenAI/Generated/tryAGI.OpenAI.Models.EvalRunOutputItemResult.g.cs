
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A single grader result for an evaluation run output item.
    /// </summary>
    public sealed partial class EvalRunOutputItemResult
    {
        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the grader considered the output a pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// Optional sample or intermediate data produced by the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        public object? Sample { get; set; }

        /// <summary>
        /// The numeric score produced by the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// The grader type (for example, "string-check-grader").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemResult" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the grader.
        /// </param>
        /// <param name="passed">
        /// Whether the grader considered the output a pass.
        /// </param>
        /// <param name="sample">
        /// Optional sample or intermediate data produced by the grader.
        /// </param>
        /// <param name="score">
        /// The numeric score produced by the grader.
        /// </param>
        /// <param name="type">
        /// The grader type (for example, "string-check-grader").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRunOutputItemResult(
            string name,
            bool passed,
            double score,
            object? sample,
            string? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Passed = passed;
            this.Score = score;
            this.Sample = sample;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemResult" /> class.
        /// </summary>
        public EvalRunOutputItemResult()
        {
        }
    }
}