
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A EvalResponsesSource object describing a run data source configuration.
    /// </summary>
    public sealed partial class EvalResponsesSource
    {
        /// <summary>
        /// The type of run data source. Always `responses`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalResponsesSourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.EvalResponsesSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions_search")]
        public string? InstructionsSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_after")]
        public int? CreatedAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_before")]
        public int? CreatedBefore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        public global::tryAGI.OpenAI.ReasoningEffortEnum? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<string>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResponsesSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of run data source. Always `responses`.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="instructionsSearch"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="users"></param>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalResponsesSource(
            global::tryAGI.OpenAI.EvalResponsesSourceType type,
            object? metadata,
            string? model,
            string? instructionsSearch,
            int? createdAfter,
            int? createdBefore,
            global::tryAGI.OpenAI.ReasoningEffortEnum? reasoningEffort,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<string>? tools)
        {
            this.Type = type;
            this.Metadata = metadata;
            this.Model = model;
            this.InstructionsSearch = instructionsSearch;
            this.CreatedAfter = createdAfter;
            this.CreatedBefore = createdBefore;
            this.ReasoningEffort = reasoningEffort;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Users = users;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResponsesSource" /> class.
        /// </summary>
        public EvalResponsesSource()
        {
        }
    }
}