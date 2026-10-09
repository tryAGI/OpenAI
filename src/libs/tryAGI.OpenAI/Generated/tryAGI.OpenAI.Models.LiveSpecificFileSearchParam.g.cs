
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveSpecificFileSearchParam
    {
        /// <summary>
        /// The tool to call. Always `file_search`.<br/>
        /// Default Value: file_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpecificFileSearchParamType.FileSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpecificFileSearchParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpecificFileSearchParamType.FileSearch;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificFileSearchParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `file_search`.<br/>
        /// Default Value: file_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpecificFileSearchParam(
            global::tryAGI.OpenAI.LiveSpecificFileSearchParamType type = global::tryAGI.OpenAI.LiveSpecificFileSearchParamType.FileSearch)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificFileSearchParam" /> class.
        /// </summary>
        public LiveSpecificFileSearchParam()
        {
        }

    }
}