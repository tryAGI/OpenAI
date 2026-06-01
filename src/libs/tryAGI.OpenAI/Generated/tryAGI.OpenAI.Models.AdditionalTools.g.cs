
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdditionalTools
    {
        /// <summary>
        /// The type of the item. Always `additional_tools`.<br/>
        /// Default Value: additional_tools
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AdditionalToolsType.AdditionalTools</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AdditionalToolsTypeJsonConverter))]
        public global::tryAGI.OpenAI.AdditionalToolsType Type { get; set; } = global::tryAGI.OpenAI.AdditionalToolsType.AdditionalTools;

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.MessageRole Role { get; set; }

        /// <summary>
        /// The additional tool definitions made available at this item.
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
        /// Initializes a new instance of the <see cref="AdditionalTools" /> class.
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
        /// <param name="type">
        /// The type of the item. Always `additional_tools`.<br/>
        /// Default Value: additional_tools
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdditionalTools(
            string id,
            global::tryAGI.OpenAI.MessageRole role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool> tools,
            global::tryAGI.OpenAI.AdditionalToolsType type = global::tryAGI.OpenAI.AdditionalToolsType.AdditionalTools)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalTools" /> class.
        /// </summary>
        public AdditionalTools()
        {
        }

    }
}