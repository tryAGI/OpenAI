
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FineTuningIntegration
    {
        /// <summary>
        /// The type of the integration being enabled for the fine-tuning job
        /// </summary>
        /// <default>"wandb"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "wandb";

        /// <summary>
        /// The settings for your integration with Weights and Biases. This payload specifies the project that<br/>
        /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags<br/>
        /// to your run, and set a default entity (team, username, etc) to be associated with your run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FineTuningIntegrationWandb Wandb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningIntegration" /> class.
        /// </summary>
        /// <param name="wandb">
        /// The settings for your integration with Weights and Biases. This payload specifies the project that<br/>
        /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags<br/>
        /// to your run, and set a default entity (team, username, etc) to be associated with your run.
        /// </param>
        /// <param name="type">
        /// The type of the integration being enabled for the fine-tuning job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuningIntegration(
            global::tryAGI.OpenAI.FineTuningIntegrationWandb wandb,
            string type = "wandb")
        {
            this.Type = type;
            this.Wandb = wandb ?? throw new global::System.ArgumentNullException(nameof(wandb));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningIntegration" /> class.
        /// </summary>
        public FineTuningIntegration()
        {
        }

        /// <summary>
        /// Creates a new <see cref="FineTuningIntegration"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static FineTuningIntegration FromWandb(global::tryAGI.OpenAI.FineTuningIntegrationWandb wandb)
        {
            return new FineTuningIntegration
            {
                Wandb = wandb,
            };
        }

    }
}