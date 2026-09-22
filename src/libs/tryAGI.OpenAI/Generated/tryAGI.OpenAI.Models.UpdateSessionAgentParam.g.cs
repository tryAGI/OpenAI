
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Model settings that can change after session creation.
    /// </summary>
    public sealed partial class UpdateSessionAgentParam
    {
        /// <summary>
        /// The model for subsequent turns. Omit to keep the current model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Reasoning settings to update. Omit to keep the current effort.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.UpdateSessionReasoningParam? Reasoning { get; set; }

        /// <summary>
        /// Omit to keep the current tier. Null resets it to auto.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::tryAGI.OpenAI.ServiceTierParam? ServiceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSessionAgentParam" /> class.
        /// </summary>
        /// <param name="model">
        /// The model for subsequent turns. Omit to keep the current model.
        /// </param>
        /// <param name="reasoning">
        /// Reasoning settings to update. Omit to keep the current effort.
        /// </param>
        /// <param name="serviceTier">
        /// Omit to keep the current tier. Null resets it to auto.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSessionAgentParam(
            string? model,
            global::tryAGI.OpenAI.UpdateSessionReasoningParam? reasoning,
            global::tryAGI.OpenAI.ServiceTierParam? serviceTier)
        {
            this.Model = model;
            this.Reasoning = reasoning;
            this.ServiceTier = serviceTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSessionAgentParam" /> class.
        /// </summary>
        public UpdateSessionAgentParam()
        {
        }

    }
}