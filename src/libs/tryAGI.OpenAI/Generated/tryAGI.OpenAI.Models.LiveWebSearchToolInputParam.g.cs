
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A web search tool available to the Live session’s Responses backend.
    /// </summary>
    public sealed partial class LiveWebSearchToolInputParam
    {
        /// <summary>
        /// The tool type. Always `web_search`.<br/>
        /// Default Value: web_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveWebSearchToolInputParamType.WebSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveWebSearchToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveWebSearchToolInputParamType.WebSearch;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveWebSearchToolInputParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool type. Always `web_search`.<br/>
        /// Default Value: web_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveWebSearchToolInputParam(
            global::tryAGI.OpenAI.LiveWebSearchToolInputParamType type = global::tryAGI.OpenAI.LiveWebSearchToolInputParamType.WebSearch)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveWebSearchToolInputParam" /> class.
        /// </summary>
        public LiveWebSearchToolInputParam()
        {
        }

    }
}