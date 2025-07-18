
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A LabelModelGrader object which uses a model to assign labels to each item<br/>
    /// in the evaluation.
    /// </summary>
    public sealed partial class CreateEvalLabelModelGrader
    {
        /// <summary>
        /// A list of chat messages forming the prompt or context. May include variable references to the `item` namespace, ie {{item.name}}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateEvalItem> Input { get; set; }

        /// <summary>
        /// The labels to classify to each item in the evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// The model to use for the evaluation. Must support structured outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The labels that indicate a passing result. Must be a subset of labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passing_labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PassingLabels { get; set; }

        /// <summary>
        /// The object type, which is always `label_model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalLabelModelGraderTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateEvalLabelModelGraderType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalLabelModelGrader" /> class.
        /// </summary>
        /// <param name="input">
        /// A list of chat messages forming the prompt or context. May include variable references to the `item` namespace, ie {{item.name}}.
        /// </param>
        /// <param name="labels">
        /// The labels to classify to each item in the evaluation.
        /// </param>
        /// <param name="model">
        /// The model to use for the evaluation. Must support structured outputs.
        /// </param>
        /// <param name="name">
        /// The name of the grader.
        /// </param>
        /// <param name="passingLabels">
        /// The labels that indicate a passing result. Must be a subset of labels.
        /// </param>
        /// <param name="type">
        /// The object type, which is always `label_model`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalLabelModelGrader(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateEvalItem> input,
            global::System.Collections.Generic.IList<string> labels,
            string model,
            string name,
            global::System.Collections.Generic.IList<string> passingLabels,
            global::tryAGI.OpenAI.CreateEvalLabelModelGraderType type)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PassingLabels = passingLabels ?? throw new global::System.ArgumentNullException(nameof(passingLabels));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalLabelModelGrader" /> class.
        /// </summary>
        public CreateEvalLabelModelGrader()
        {
        }
    }
}