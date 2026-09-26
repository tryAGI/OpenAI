
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The json schema for the run data source items.<br/>
    /// Learn how to build JSON schemas [here](https://json-schema.org/).<br/>
    /// Example: {"type":"object","properties":{"item":{"type":"object","properties":{"label":{"type":"string"}},"required":["label"]}},"required":["item"]}
    /// </summary>
    public sealed partial class EvalCustomDataSourceConfigSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}