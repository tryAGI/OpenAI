
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use this option to force the model to call a specific custom tool.
    /// </summary>
    public sealed partial class BetaToolChoiceCustom
    {
        /// <summary>
        /// For custom tool calling, the type is always `custom`.
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// The name of the custom tool to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChoiceCustom" /> class.
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
        public BetaToolChoiceCustom(
            string name,
            string type = "custom")
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChoiceCustom" /> class.
        /// </summary>
        public BetaToolChoiceCustom()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaToolChoiceCustom"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaToolChoiceCustom FromName(string name)
        {
            return new BetaToolChoiceCustom
            {
                Name = name,
            };
        }

    }
}