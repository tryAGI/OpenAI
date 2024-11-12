
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The per-line object of the batch output and error files
    /// </summary>
    public sealed partial class BatchRequestOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// A developer-provided per-request id that will be used to match outputs to inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::OpenAI.BatchRequestOutputResponse? Response { get; set; }

        /// <summary>
        /// For requests that failed with a non-HTTP error, this will contain more information on the cause of the failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::OpenAI.BatchRequestOutputError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customId">
        /// A developer-provided per-request id that will be used to match outputs to inputs.
        /// </param>
        /// <param name="response"></param>
        /// <param name="error">
        /// For requests that failed with a non-HTTP error, this will contain more information on the cause of the failure.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BatchRequestOutput(
            string? id,
            string? customId,
            global::OpenAI.BatchRequestOutputResponse? response,
            global::OpenAI.BatchRequestOutputError? error)
        {
            this.Id = id;
            this.CustomId = customId;
            this.Response = response;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutput" /> class.
        /// </summary>
        public BatchRequestOutput()
        {
        }
    }
}