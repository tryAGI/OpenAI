
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveSpecificWebSearchParam
    {
        /// <summary>
        /// The tool to call. Always `web_search`.<br/>
        /// Default Value: web_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpecificWebSearchParamType.WebSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpecificWebSearchParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpecificWebSearchParamType.WebSearch;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificWebSearchParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `web_search`.<br/>
        /// Default Value: web_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpecificWebSearchParam(
            global::tryAGI.OpenAI.LiveSpecificWebSearchParamType type = global::tryAGI.OpenAI.LiveSpecificWebSearchParamType.WebSearch)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificWebSearchParam" /> class.
        /// </summary>
        public LiveSpecificWebSearchParam()
        {
        }

    }
}