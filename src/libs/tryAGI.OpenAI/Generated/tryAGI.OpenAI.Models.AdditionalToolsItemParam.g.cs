
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdditionalToolsItemParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The item type. Always `additional_tools`.<br/>
        /// Default Value: additional_tools
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AdditionalToolsItemParamType.AdditionalTools</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AdditionalToolsItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.AdditionalToolsItemParamType Type { get; set; } = global::tryAGI.OpenAI.AdditionalToolsItemParamType.AdditionalTools;

        /// <summary>
        /// The role that provided the additional tools. Only `developer` is supported.<br/>
        /// Default Value: developer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AdditionalToolsItemParamRole.Developer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AdditionalToolsItemParamRoleJsonConverter))]
        public global::tryAGI.OpenAI.AdditionalToolsItemParamRole Role { get; set; } = global::tryAGI.OpenAI.AdditionalToolsItemParamRole.Developer;

        /// <summary>
        /// A list of additional tools made available at this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalToolsItemParam" /> class.
        /// </summary>
        /// <param name="tools">
        /// A list of additional tools made available at this item.
        /// </param>
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
        public AdditionalToolsItemParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool> tools,
            string? id,
            global::tryAGI.OpenAI.AdditionalToolsItemParamType type = global::tryAGI.OpenAI.AdditionalToolsItemParamType.AdditionalTools,
            global::tryAGI.OpenAI.AdditionalToolsItemParamRole role = global::tryAGI.OpenAI.AdditionalToolsItemParamRole.Developer)
        {
            this.Id = id;
            this.Type = type;
            this.Role = role;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalToolsItemParam" /> class.
        /// </summary>
        public AdditionalToolsItemParam()
        {
        }

    }
}