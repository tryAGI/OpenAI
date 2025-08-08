
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use this option to force the model to call a specific custom tool.
    /// </summary>
    public sealed partial class ToolChoiceCustom
    {
        /// <summary>
        /// The name of the custom tool to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// For custom tool calling, the type is always `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceCustomTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolChoiceCustomType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceCustom" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the custom tool to call.
        /// </param>
        /// <param name="type">
        /// For custom tool calling, the type is always `custom`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceCustom(
            string name,
            global::tryAGI.OpenAI.ToolChoiceCustomType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceCustom" /> class.
        /// </summary>
        public ToolChoiceCustom()
        {
        }
    }
}