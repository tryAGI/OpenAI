
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaAdditionalTools
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the item. Always `additional_tools`.<br/>
        /// Default Value: additional_tools
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaAdditionalToolsType.AdditionalTools</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaAdditionalToolsType Type { get; set; } = global::tryAGI.OpenAI.BetaAdditionalToolsType.AdditionalTools;

        /// <summary>
        /// The unique ID of the additional tools item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The role that provided the additional tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaMessageRole Role { get; set; }

        /// <summary>
        /// The additional tool definitions made available at this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAdditionalTools" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the additional tools item.
        /// </param>
        /// <param name="role">
        /// The role that provided the additional tools.
        /// </param>
        /// <param name="tools">
        /// The additional tool definitions made available at this item.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the item. Always `additional_tools`.<br/>
        /// Default Value: additional_tools
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAdditionalTools(
            string id,
            global::tryAGI.OpenAI.BetaMessageRole role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool> tools,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaAdditionalToolsType type = global::tryAGI.OpenAI.BetaAdditionalToolsType.AdditionalTools)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAdditionalTools" /> class.
        /// </summary>
        public BetaAdditionalTools()
        {
        }

    }
}