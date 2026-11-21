
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// JSON Schema response format. Used to generate structured JSON responses.<br/>
    /// Learn more about [Structured Outputs](https://developers.openai.com/api/docs/guides/structured-outputs).
    /// </summary>
    public sealed partial class ResponseFormatJsonSchema
    {
        /// <summary>
        /// The type of response format being defined. Always `json_schema`.
        /// </summary>
        /// <default>"json_schema"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "json_schema";

        /// <summary>
        /// Structured Outputs configuration options, including a JSON Schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonSchema" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// Structured Outputs configuration options, including a JSON Schema.
        /// </param>
        /// <param name="type">
        /// The type of response format being defined. Always `json_schema`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormatJsonSchema(
            global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema jsonSchema,
            string type = "json_schema")
        {
            this.Type = type;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonSchema" /> class.
        /// </summary>
        public ResponseFormatJsonSchema()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseFormatJsonSchema"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseFormatJsonSchema FromJsonSchema(global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema jsonSchema)
        {
            return new ResponseFormatJsonSchema
            {
                JsonSchema = jsonSchema,
            };
        }

    }
}