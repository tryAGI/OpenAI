
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for the DPO fine-tuning method.
    /// </summary>
    public sealed partial class FineTuneDPOMethod
    {
        /// <summary>
        /// The hyperparameters used for the DPO fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        public global::tryAGI.OpenAI.FineTuneDPOHyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOMethod" /> class.
        /// </summary>
        /// <param name="hyperparameters">
        /// The hyperparameters used for the DPO fine-tuning job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneDPOMethod(
            global::tryAGI.OpenAI.FineTuneDPOHyperparameters? hyperparameters)
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