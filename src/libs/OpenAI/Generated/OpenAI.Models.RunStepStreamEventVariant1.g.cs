
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) is created.
    /// </summary>
    public sealed partial class RunStepStreamEventVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RunStepStreamEventVariant1EventJsonConverter))]
        public global::OpenAI.RunStepStreamEventVariant1Event Event { get; set; }

        /// <summary>
        /// Represents a step in execution of a run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunStepObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}