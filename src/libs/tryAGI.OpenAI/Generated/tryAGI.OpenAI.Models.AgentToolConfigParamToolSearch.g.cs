
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Discovers deferred function tools and loads them into the model context.
    /// </summary>
    public sealed partial class AgentToolConfigParamToolSearch
    {
        /// <summary>
        /// The type of the object. Always `tool_search`.<br/>
        /// Default Value: tool_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType.ToolSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamToolSearchTypeJsonConverter))]
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType Type { get; set; } = global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType.ToolSearch;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolConfigParamToolSearch" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `tool_search`.<br/>
        /// Default Value: tool_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolConfigParamToolSearch(
            global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType type = global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType.ToolSearch)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolConfigParamToolSearch" /> class.
        /// </summary>
        public AgentToolConfigParamToolSearch()
        {
        }

    }
}