
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A JsonlRunDataSource object with that specifies a JSONL file that matches the eval 
    /// </summary>
    public sealed partial class CreateEvalJsonlRunDataSource
    {
        /// <summary>
        /// Determines what populates the `item` namespace in the data source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.Source2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Source2 Source { get; set; }

        /// <summary>
        /// The type of data source. Always `jsonl`.<br/>
        /// Default Value: jsonl
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateEvalJsonlRunDataSourceType.Jsonl</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalJsonlRunDataSourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateEvalJsonlRunDataSourceType Type { get; set; } = global::tryAGI.OpenAI.CreateEvalJsonlRunDataSourceType.Jsonl;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalJsonlRunDataSource" /> class.
        /// </summary>
        /// <param name="source">
        /// Determines what populates the `item` namespace in the data source.
        /// </param>
        /// <param name="type">
        /// The type of data source. Always `jsonl`.<br/>
        /// Default Value: jsonl
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalJsonlRunDataSource(
            global::tryAGI.OpenAI.Source2 source,
            global::tryAGI.OpenAI.CreateEvalJsonlRunDataSourceType type = global::tryAGI.OpenAI.CreateEvalJsonlRunDataSourceType.Jsonl)
        {
            this.Source = source;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalJsonlRunDataSource" /> class.
        /// </summary>
        public CreateEvalJsonlRunDataSource()
        {
        }
    }
}