
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveFileSearchToolInputParam
    {
        /// <summary>
        /// Default Value: file_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveFileSearchToolInputParamType.FileSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveFileSearchToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveFileSearchToolInputParamType.FileSearch;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveFileSearchToolInputParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: file_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveFileSearchToolInputParam(
            global::tryAGI.OpenAI.LiveFileSearchToolInputParamType type = global::tryAGI.OpenAI.LiveFileSearchToolInputParamType.FileSearch)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveFileSearchToolInputParam" /> class.
        /// </summary>
        public LiveFileSearchToolInputParam()
        {
        }

    }
}