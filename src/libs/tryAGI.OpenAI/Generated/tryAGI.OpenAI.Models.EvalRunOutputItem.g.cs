
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A schema representing an evaluation run output item.
    /// </summary>
    public sealed partial class EvalRunOutputItem
    {
        /// <summary>
        /// The type of the object. Always "eval.run.output_item".<br/>
        /// Default Value: eval.run.output_item
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EvalRunOutputItemObject.EvalRunOutputItem</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunOutputItemObjectJsonConverter))]
        public global::tryAGI.OpenAI.EvalRunOutputItemObject Object { get; set; } = global::tryAGI.OpenAI.EvalRunOutputItemObject.EvalRunOutputItem;

        /// <summary>
        /// Unique identifier for the evaluation run output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The identifier of the evaluation run associated with this output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string RunId { get; set; } = default!;

        /// <summary>
        /// The identifier of the evaluation group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string EvalId { get; set; } = default!;

        /// <summary>
        /// Unix timestamp (in seconds) when the evaluation run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The status of the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Status { get; set; } = default!;

        /// <summary>
        /// The identifier for the data source item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasource_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int DatasourceItemId { get; set; } = default!;

        /// <summary>
        /// Details of the input data source item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasource_item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public object DatasourceItem { get; set; } = default!;

        /// <summary>
        /// A list of grader results for this output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemResult> Results { get; set; } = default!;

        /// <summary>
        /// A sample containing the input and output of the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.EvalRunOutputItemSample Sample { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItem" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of the object. Always "eval.run.output_item".<br/>
        /// Default Value: eval.run.output_item
        /// </param>
        /// <param name="id">
        /// Unique identifier for the evaluation run output item.
        /// </param>
        /// <param name="runId">
        /// The identifier of the evaluation run associated with this output item.
        /// </param>
        /// <param name="evalId">
        /// The identifier of the evaluation group.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the evaluation run was created.
        /// </param>
        /// <param name="status">
        /// The status of the evaluation run.
        /// </param>
        /// <param name="datasourceItemId">
        /// The identifier for the data source item.
        /// </param>
        /// <param name="datasourceItem">
        /// Details of the input data source item.
        /// </param>
        /// <param name="results">
        /// A list of grader results for this output item.
        /// </param>
        /// <param name="sample">
        /// A sample containing the input and output of the evaluation run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRunOutputItem(
            string id,
            string runId,
            string evalId,
            global::System.DateTimeOffset createdAt,
            string status,
            int datasourceItemId,
            object datasourceItem,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemResult> results,
            global::tryAGI.OpenAI.EvalRunOutputItemSample sample,
            global::tryAGI.OpenAI.EvalRunOutputItemObject @object = global::tryAGI.OpenAI.EvalRunOutputItemObject.EvalRunOutputItem)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.EvalId = evalId ?? throw new global::System.ArgumentNullException(nameof(evalId));
            this.CreatedAt = createdAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.DatasourceItemId = datasourceItemId;
            this.DatasourceItem = datasourceItem ?? throw new global::System.ArgumentNullException(nameof(datasourceItem));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Sample = sample ?? throw new global::System.ArgumentNullException(nameof(sample));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItem" /> class.
        /// </summary>
        public EvalRunOutputItem()
        {
        }
    }
}