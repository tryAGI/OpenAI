
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Configuration for the DPO fine-tuning method.
    /// </summary>
    public sealed partial class FineTuneDPOMethod
    {
        /// <summary>
        /// The hyperparameters used for the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        public global::OpenAI.FineTuneDPOMethodHyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOMethod" /> class.
        /// </summary>
        /// <param name="hyperparameters">
        /// The hyperparameters used for the fine-tuning job.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FineTuneDPOMethod(
            global::OpenAI.FineTuneDPOMethodHyperparameters? hyperparameters)
        {
            this.Hyperparameters = hyperparameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOMethod" /> class.
        /// </summary>
        public FineTuneDPOMethod()
        {
        }
    }
}