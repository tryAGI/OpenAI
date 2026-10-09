
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveMCPToolChoiceParam
    {
        /// <summary>
        /// The tool to call. Always `mcp`.<br/>
        /// Default Value: mcp
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveMCPToolChoiceParamType.Mcp</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveMCPToolChoiceParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParamType Type { get; set; } = global::tryAGI.OpenAI.LiveMCPToolChoiceParamType.Mcp;

        /// <summary>
        /// The label of the MCP server to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMCPToolChoiceParam" /> class.
        /// </summary>
        /// <param name="serverLabel">
        /// The label of the MCP server to call.
        /// </param>
        /// <param name="name"></param>
        /// <param name="type">
        /// The tool to call. Always `mcp`.<br/>
        /// Default Value: mcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveMCPToolChoiceParam(
            string serverLabel,
            string? name,
            global::tryAGI.OpenAI.LiveMCPToolChoiceParamType type = global::tryAGI.OpenAI.LiveMCPToolChoiceParamType.Mcp)
        {
            this.Type = type;
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMCPToolChoiceParam" /> class.
        /// </summary>
        public LiveMCPToolChoiceParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveMCPToolChoiceParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveMCPToolChoiceParam FromServerLabel(string serverLabel)
        {
            return new LiveMCPToolChoiceParam
            {
                ServerLabel = serverLabel,
            };
        }

    }
}