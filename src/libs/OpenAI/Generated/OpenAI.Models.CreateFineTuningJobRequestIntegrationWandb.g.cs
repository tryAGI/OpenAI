
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The settings for your integration with Weights and Biases. This payload specifies the project that<br/>
    /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags<br/>
    /// to your run, and set a default entity (team, username, etc) to be associated with your run.
    /// </summary>
    public sealed partial class CreateFineTuningJobRequestIntegrationWandb
    {
        /// <summary>
        /// The name of the project that the new run will be created under.<br/>
        /// Example: my-wandb-project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// A display name to set for the run. If not set, we will use the Job ID as the name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The entity to use for the run. This allows you to set the team or username of the WandB user that you would<br/>
        /// like associated with the run. If not set, the default entity for the registered WandB API key is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// A list of tags to be attached to the newly created run. These tags are passed through directly to WandB. Some<br/>
        /// default tags are generated by OpenAI: "openai/finetune", "openai/{base-model}", "openai/{ftjob-abcdef}".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}