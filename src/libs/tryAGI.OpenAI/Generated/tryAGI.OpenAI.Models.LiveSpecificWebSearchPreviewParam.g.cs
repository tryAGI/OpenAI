
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveSpecificWebSearchPreviewParam
    {
        /// <summary>
        /// The tool to call. Always `web_search_preview`.<br/>
        /// Default Value: web_search_preview
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType.WebSearchPreview</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpecificWebSearchPreviewParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType.WebSearchPreview;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificWebSearchPreviewParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `web_search_preview`.<br/>
        /// Default Value: web_search_preview
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpecificWebSearchPreviewParam(
            global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType type = global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParamType.WebSearchPreview)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificWebSearchPreviewParam" /> class.
        /// </summary>
        public LiveSpecificWebSearchPreviewParam()
        {
        }

    }
}