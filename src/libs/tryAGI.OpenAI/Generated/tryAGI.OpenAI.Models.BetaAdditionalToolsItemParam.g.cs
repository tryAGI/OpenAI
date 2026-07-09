
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaAdditionalToolsItemParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTagParam? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The item type. Always `additional_tools`.<br/>
        /// Default Value: additional_tools
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType.AdditionalTools</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType.AdditionalTools;

        /// <summary>
        /// The role that provided the additional tools. Only `developer` is supported.<br/>
        /// Default Value: developer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole.Developer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsItemParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole Role { get; set; } = global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole.Developer;

        /// <summary>
        /// A list of additional tools made available at this item.
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
        /// Initializes a new instance of the <see cref="BetaAdditionalToolsItemParam" /> class.
        /// </summary>
        /// <param name="tools">
        /// A list of additional tools made available at this item.
        /// </param>
        /// <param name="agent"></param>
        /// <param name="id"></param>
        /// <param name="type">
        /// The item type. Always `additional_tools`.<br/>
        /// Default Value: additional_tools
        /// </param>
        /// <param name="role">
        /// The role that provided the additional tools. Only `developer` is supported.<br/>
        /// Default Value: developer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAdditionalToolsItemParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool> tools,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            string? id,
            global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType type = global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType.AdditionalTools,
            global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole role = global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole.Developer)
        {
            this.Agent = agent;
            this.Id = id;
            this.Type = type;
            this.Role = role;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAdditionalToolsItemParam" /> class.
        /// </summary>
        public BetaAdditionalToolsItemParam()
        {
        }

    }
}