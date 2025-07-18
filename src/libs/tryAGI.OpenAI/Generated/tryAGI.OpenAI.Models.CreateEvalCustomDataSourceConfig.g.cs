
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A CustomDataSourceConfig object that defines the schema for the data source used for the evaluation runs.<br/>
    /// This schema is used to define the shape of the data that will be:<br/>
    /// - Used to define your testing criteria and<br/>
    /// - What data is required when creating a run
    /// </summary>
    public sealed partial class CreateEvalCustomDataSourceConfig
    {
        /// <summary>
        /// Whether the eval should expect you to populate the sample namespace (ie, by generating responses off of your data source)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_sample_schema")]
        public bool? IncludeSampleSchema { get; set; }

        /// <summary>
        /// The json schema for each row in the data source.<br/>
        /// Example: {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {"type": "string"},<br/>
        ///     "age": {"type": "integer"}<br/>
        ///   },<br/>
        ///   "required": ["name", "age"]<br/>
        /// }
        /// </summary>
        /// <example>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {"type": "string"},<br/>
        ///     "age": {"type": "integer"}<br/>
        ///   },<br/>
        ///   "required": ["name", "age"]<br/>
        /// }
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ItemSchema { get; set; }

        /// <summary>
        /// The type of data source. Always `custom`.<br/>
        /// Default Value: custom
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfigType.Custom</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalCustomDataSourceConfigTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfigType Type { get; set; } = global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfigType.Custom;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCustomDataSourceConfig" /> class.
        /// </summary>
        /// <param name="includeSampleSchema">
        /// Whether the eval should expect you to populate the sample namespace (ie, by generating responses off of your data source)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="itemSchema">
        /// The json schema for each row in the data source.<br/>
        /// Example: {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {"type": "string"},<br/>
        ///     "age": {"type": "integer"}<br/>
        ///   },<br/>
        ///   "required": ["name", "age"]<br/>
        /// }
        /// </param>
        /// <param name="type">
        /// The type of data source. Always `custom`.<br/>
        /// Default Value: custom
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalCustomDataSourceConfig(
            object itemSchema,
            bool? includeSampleSchema,
            global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfigType type = global::tryAGI.OpenAI.CreateEvalCustomDataSourceConfigType.Custom)
        {
            this.ItemSchema = itemSchema ?? throw new global::System.ArgumentNullException(nameof(itemSchema));
            this.IncludeSampleSchema = includeSampleSchema;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCustomDataSourceConfig" /> class.
        /// </summary>
        public CreateEvalCustomDataSourceConfig()
        {
        }
    }
}