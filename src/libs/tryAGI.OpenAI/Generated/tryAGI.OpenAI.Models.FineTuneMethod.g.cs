
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The method used for fine-tuning.
    /// </summary>
    public sealed partial class FineTuneMethod
    {
        /// <summary>
        /// Configuration for the DPO fine-tuning method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo")]
        public global::tryAGI.OpenAI.FineTuneDPOMethod? Dpo { get; set; }

        /// <summary>
        /// Configuration for the reinforcement fine-tuning method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reinforcement")]
        public global::tryAGI.OpenAI.FineTuneReinforcementMethod? Reinforcement { get; set; }

        /// <summary>
        /// Configuration for the supervised fine-tuning method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supervised")]
        public global::tryAGI.OpenAI.FineTuneSupervisedMethod? Supervised { get; set; }

        /// <summary>
        /// The type of method. Is either `supervised`, `dpo`, or `reinforcement`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FineTuneMethodTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FineTuneMethodType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneMethod" /> class.
        /// </summary>
        /// <param name="dpo">
        /// Configuration for the DPO fine-tuning method.
        /// </param>
        /// <param name="reinforcement">
        /// Configuration for the reinforcement fine-tuning method.
        /// </param>
        /// <param name="supervised">
        /// Configuration for the supervised fine-tuning method.
        /// </param>
        /// <param name="type">
        /// The type of method. Is either `supervised`, `dpo`, or `reinforcement`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneMethod(
            global::tryAGI.OpenAI.FineTuneMethodType type,
            global::tryAGI.OpenAI.FineTuneDPOMethod? dpo,
            global::tryAGI.OpenAI.FineTuneReinforcementMethod? reinforcement,
            global::tryAGI.OpenAI.FineTuneSupervisedMethod? supervised)
        {
            this.Type = type;
            this.Dpo = dpo;
            this.Reinforcement = reinforcement;
            this.Supervised = supervised;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneMethod" /> class.
        /// </summary>
        public FineTuneMethod()
        {
        }
    }
}