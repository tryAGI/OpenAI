
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Groups function/custom tools under a shared namespace.
    /// </summary>
    public sealed partial class NamespaceToolParam
    {
        /// <summary>
        /// The type of the tool. Always `namespace`.<br/>
        /// Default Value: namespace
        /// </summary>
        /// <default>global::tryAGI.OpenAI.NamespaceToolParamType.Namespace</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.NamespaceToolParamType Type { get; set; } = global::tryAGI.OpenAI.NamespaceToolParamType.Namespace;

        /// <summary>
        /// The namespace name used in tool calls (for example, `crm`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the namespace shown to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The function/custom tools available inside this namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem13> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceToolParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the tool. Always `namespace`.<br/>
        /// Default Value: namespace
        /// </param>
        /// <param name="name">
        /// The namespace name used in tool calls (for example, `crm`).
        /// </param>
        /// <param name="description">
        /// A description of the namespace shown to the model.
        /// </param>
        /// <param name="tools">
        /// The function/custom tools available inside this namespace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamespaceToolParam(
            string name,
            string description,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem13> tools,
            global::tryAGI.OpenAI.NamespaceToolParamType type = global::tryAGI.OpenAI.NamespaceToolParamType.Namespace)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceToolParam" /> class.
        /// </summary>
        public NamespaceToolParam()
        {
        }
    }
}