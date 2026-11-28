
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use this option to force the model to call a specific function.
    /// </summary>
    public sealed partial class ToolChoiceFunction
    {
        /// <summary>
        /// For function calling, the type is always `function`.
        /// </summary>
        /// <default>"function"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "function";

        /// <summary>
        /// The name of the function to call.
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
        /// Initializes a new instance of the <see cref="ToolChoiceFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        /// <param name="type">
        /// For function calling, the type is always `function`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceFunction(
            string name,
            string type = "function")
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceFunction" /> class.
        /// </summary>
        public ToolChoiceFunction()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ToolChoiceFunction"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ToolChoiceFunction FromName(string name)
        {
            return new ToolChoiceFunction
            {
                Name = name,
            };
        }

    }
}