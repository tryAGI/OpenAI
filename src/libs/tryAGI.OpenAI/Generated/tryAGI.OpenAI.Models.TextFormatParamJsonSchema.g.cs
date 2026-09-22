
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains generated text to a JSON Schema.
    /// </summary>
    public sealed partial class TextFormatParamJsonSchema
    {
        /// <summary>
        /// The type of the object. Always `json_schema`.<br/>
        /// Default Value: json_schema
        /// </summary>
        /// <default>global::tryAGI.OpenAI.TextFormatParamJsonSchemaType.JsonSchema</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TextFormatParamJsonSchemaTypeJsonConverter))]
        public global::tryAGI.OpenAI.TextFormatParamJsonSchemaType Type { get; set; } = global::tryAGI.OpenAI.TextFormatParamJsonSchemaType.JsonSchema;

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
        /// Initializes a new instance of the <see cref="TextFormatParamJsonSchema" /> class.
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
        public TextFormatParamJsonSchema(
            object schema,
            global::tryAGI.OpenAI.TextFormatParamJsonSchemaType type = global::tryAGI.OpenAI.TextFormatParamJsonSchemaType.JsonSchema)
        {
            this.Type = type;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFormatParamJsonSchema" /> class.
        /// </summary>
        public TextFormatParamJsonSchema()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TextFormatParamJsonSchema"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TextFormatParamJsonSchema FromSchema(object schema)
        {
            return new TextFormatParamJsonSchema
            {
                Schema = schema,
            };
        }

    }
}