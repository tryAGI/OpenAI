
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalRunRequest
    {
        /// <summary>
        /// Details about the run's data source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource> DataSource { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The name of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalRunRequest" /> class.
        /// </summary>
        /// <param name="dataSource">
        /// Details about the run's data source.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="name">
        /// The name of the run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalRunRequest(
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource> dataSource,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? name)
        {
            this.DataSource = dataSource;
            this.Metadata = metadata;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalRunRequest" /> class.
        /// </summary>
        public CreateEvalRunRequest()
        {
        }
    }
}