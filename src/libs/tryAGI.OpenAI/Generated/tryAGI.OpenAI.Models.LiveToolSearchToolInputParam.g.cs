
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveToolSearchToolInputParam
    {
        /// <summary>
        /// Default Value: tool_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveToolSearchToolInputParamType.ToolSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveToolSearchToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveToolSearchToolInputParamType.ToolSearch;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveToolSearchToolInputParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: tool_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveToolSearchToolInputParam(
            global::tryAGI.OpenAI.LiveToolSearchToolInputParamType type = global::tryAGI.OpenAI.LiveToolSearchToolInputParamType.ToolSearch)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveToolSearchToolInputParam" /> class.
        /// </summary>
        public LiveToolSearchToolInputParam()
        {
        }

    }
}