
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The dataset item provided to the grader. This will be used to populate <br/>
    /// the `item` namespace. See [the guide](/docs/guides/graders) for more details. 
    /// </summary>
    public sealed partial class RunGraderRequestItem
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}