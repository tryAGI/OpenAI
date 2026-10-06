
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveMCPToolInputParam
    {
        /// <summary>
        /// Default Value: mcp
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveMCPToolInputParamType.Mcp</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveMCPToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveMCPToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveMCPToolInputParamType.Mcp;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMCPToolInputParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: mcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveMCPToolInputParam(
            global::tryAGI.OpenAI.LiveMCPToolInputParamType type = global::tryAGI.OpenAI.LiveMCPToolInputParamType.Mcp)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMCPToolInputParam" /> class.
        /// </summary>
        public LiveMCPToolInputParam()
        {
        }

    }
}