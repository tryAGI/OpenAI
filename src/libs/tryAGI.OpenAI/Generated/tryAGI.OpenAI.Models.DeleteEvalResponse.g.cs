
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteEvalResponse
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Example: eval_abc123
        /// </summary>
        /// <example>eval_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvalId { get; set; }

        /// <summary>
        /// Example: eval.deleted
        /// </summary>
        /// <example>eval.deleted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEvalResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Example: true
        /// </param>
        /// <param name="evalId">
        /// Example: eval_abc123
        /// </param>
        /// <param name="object">
        /// Example: eval.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteEvalResponse(
            bool deleted,
            string evalId,
            string @object)
        {
            this.Deleted = deleted;
            this.EvalId = evalId ?? throw new global::System.ArgumentNullException(nameof(evalId));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEvalResponse" /> class.
        /// </summary>
        public DeleteEvalResponse()
        {
        }
    }
}