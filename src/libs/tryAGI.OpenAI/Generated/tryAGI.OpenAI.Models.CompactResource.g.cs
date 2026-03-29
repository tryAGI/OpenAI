
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Example: {"id":"resp_001","object":"response.compaction","output":[{"type":"message","role":"user","content":[{"type":"input_text","text":"Summarize our launch checklist from last week."}]},{"type":"message","role":"user","content":[{"type":"input_text","text":"You are performing a CONTEXT CHECKPOINT COMPACTION..."}]},{"type":"compaction","id":"cmp_001","encrypted_content":"encrypted-summary"}],"created_at":1731459200,"usage":{"input_tokens":42897,"output_tokens":12000,"total_tokens":54912}}
    /// </summary>
    public sealed partial class CompactResource
    {
        /// <summary>
        /// The unique identifier for the compacted response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `response.compaction`.<br/>
        /// Default Value: response.compaction
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CompactResourceObject.ResponseCompaction</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CompactResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.CompactResourceObject Object { get; set; } = global::tryAGI.OpenAI.CompactResourceObject.ResponseCompaction;

        /// <summary>
        /// The compacted list of output items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemField> Output { get; set; }

        /// <summary>
        /// Unix timestamp (in seconds) when the compacted conversation was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Token accounting for the compaction pass, including cached, reasoning, and total tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ResponseUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the compacted response.
        /// </param>
        /// <param name="output">
        /// The compacted list of output items.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the compacted conversation was created.
        /// </param>
        /// <param name="usage">
        /// Token accounting for the compaction pass, including cached, reasoning, and total tokens.
        /// </param>
        /// <param name="object">
        /// The object type. Always `response.compaction`.<br/>
        /// Default Value: response.compaction
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactResource(
            string id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemField> output,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.ResponseUsage usage,
            global::tryAGI.OpenAI.CompactResourceObject @object = global::tryAGI.OpenAI.CompactResourceObject.ResponseCompaction)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.CreatedAt = createdAt;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactResource" /> class.
        /// </summary>
        public CompactResource()
        {
        }
    }
}