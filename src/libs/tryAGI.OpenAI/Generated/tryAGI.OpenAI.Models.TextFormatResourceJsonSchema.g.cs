
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains generated text to a JSON Schema.
    /// </summary>
    public sealed partial class TextFormatResourceJsonSchema
    {
        /// <summary>
        /// The type of the object. Always `json_schema`.<br/>
        /// Default Value: json_schema
        /// </summary>
        /// <default>global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType.JsonSchema</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TextFormatResourceJsonSchemaTypeJsonConverter))]
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType Type { get; set; } = global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType.JsonSchema;

        /// <summary>
        /// The JSON Schema that generated text must match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFormatResourceJsonSchema" /> class.
        /// </summary>
        /// <param name="schema">
        /// The JSON Schema that generated text must match.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `json_schema`.<br/>
        /// Default Value: json_schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextFormatResourceJsonSchema(
            object schema,
            global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType type = global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType.JsonSchema)
        {
            this.Type = type;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFormatResourceJsonSchema" /> class.
        /// </summary>
        public TextFormatResourceJsonSchema()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TextFormatResourceJsonSchema"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TextFormatResourceJsonSchema FromSchema(object schema)
        {
            return new TextFormatResourceJsonSchema
            {
                Schema = schema,
            };
        }

    }
}