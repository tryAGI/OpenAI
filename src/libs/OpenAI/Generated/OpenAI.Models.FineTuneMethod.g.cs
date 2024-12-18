
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The method used for fine-tuning.
    /// </summary>
    public sealed partial class FineTuneMethod
    {
        /// <summary>
        /// The type of method. Is either `supervised` or `dpo`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.FineTuneMethodTypeJsonConverter))]
        public global::OpenAI.FineTuneMethodType? Type { get; set; }

        /// <summary>
        /// Configuration for the supervised fine-tuning method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supervised")]
        public global::OpenAI.FineTuneSupervisedMethod? Supervised { get; set; }

        /// <summary>
        /// Configuration for the DPO fine-tuning method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo")]
        public global::OpenAI.FineTuneDPOMethod? Dpo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneMethod" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of method. Is either `supervised` or `dpo`.
        /// </param>
        /// <param name="supervised">
        /// Configuration for the supervised fine-tuning method.
        /// </param>
        /// <param name="dpo">
        /// Configuration for the DPO fine-tuning method.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FineTuneMethod(
            global::OpenAI.FineTuneMethodType? type,
            global::OpenAI.FineTuneSupervisedMethod? supervised,
            global::OpenAI.FineTuneDPOMethod? dpo)
        {
            this.Type = type;
            this.Supervised = supervised;
            this.Dpo = dpo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneMethod" /> class.
        /// </summary>
        public FineTuneMethod()
        {
        }
    }
}