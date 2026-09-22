
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A call to a tool on an MCP server.
    /// </summary>
    public sealed partial class McpCallItemResource
    {
        /// <summary>
        /// The item type. Always `mcp_call`.<br/>
        /// Default Value: mcp_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.McpCallItemResourceType.McpCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.McpCallItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.McpCallItemResourceType Type { get; set; } = global::tryAGI.OpenAI.McpCallItemResourceType.McpCall;

        /// <summary>
        /// The ID of the MCP call item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the turn that contains this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The label of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// The name of the MCP tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The arguments passed to the MCP tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// The status of the MCP tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.FunctionCallStatusResource Status { get; set; }

        /// <summary>
        /// The output returned by the MCP tool, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// The error returned by the MCP tool, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpCallItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the MCP call item.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server.
        /// </param>
        /// <param name="name">
        /// The name of the MCP tool.
        /// </param>
        /// <param name="arguments">
        /// The arguments passed to the MCP tool.
        /// </param>
        /// <param name="status">
        /// The status of the MCP tool call.
        /// </param>
        /// <param name="output">
        /// The output returned by the MCP tool, if any.
        /// </param>
        /// <param name="error">
        /// The error returned by the MCP tool, if any.
        /// </param>
        /// <param name="type">
        /// The item type. Always `mcp_call`.<br/>
        /// Default Value: mcp_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpCallItemResource(
            string id,
            string turnId,
            string serverLabel,
            string name,
            object arguments,
            global::tryAGI.OpenAI.FunctionCallStatusResource status,
            object? output,
            object? error,
            global::tryAGI.OpenAI.McpCallItemResourceType type = global::tryAGI.OpenAI.McpCallItemResourceType.McpCall)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Status = status;
            this.Output = output;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpCallItemResource" /> class.
        /// </summary>
        public McpCallItemResource()
        {
        }

    }
}