
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalJsonlFileIdSource
    {
        /// <summary>
        /// The identifier of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of jsonl source. Always `file_id`.<br/>
        /// Default Value: file_id
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EvalJsonlFileIdSourceType.FileId</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalJsonlFileIdSourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.EvalJsonlFileIdSourceType Type { get; set; } = global::tryAGI.OpenAI.EvalJsonlFileIdSourceType.FileId;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileIdSource" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the file.
        /// </param>
        /// <param name="type">
        /// The type of jsonl source. Always `file_id`.<br/>
        /// Default Value: file_id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalJsonlFileIdSource(
            string id,
            global::tryAGI.OpenAI.EvalJsonlFileIdSourceType type = global::tryAGI.OpenAI.EvalJsonlFileIdSourceType.FileId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileIdSource" /> class.
        /// </summary>
        public EvalJsonlFileIdSource()
        {
        }
    }
}