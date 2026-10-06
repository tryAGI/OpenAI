
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveCustomToolInputParam
    {
        /// <summary>
        /// Default Value: custom
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveCustomToolInputParamType.Custom</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveCustomToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveCustomToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveCustomToolInputParamType.Custom;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCustomToolInputParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: custom
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveCustomToolInputParam(
            global::tryAGI.OpenAI.LiveCustomToolInputParamType type = global::tryAGI.OpenAI.LiveCustomToolInputParamType.Custom)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCustomToolInputParam" /> class.
        /// </summary>
        public LiveCustomToolInputParam()
        {
        }

    }
}