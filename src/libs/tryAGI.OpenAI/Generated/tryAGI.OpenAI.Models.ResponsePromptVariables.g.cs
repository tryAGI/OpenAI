
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Optional map of values to substitute in for variables in your<br/>
    /// prompt. The substitution values can either be strings, or other<br/>
    /// Response input types like images or files.
    /// </summary>
    public sealed partial class ResponsePromptVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}