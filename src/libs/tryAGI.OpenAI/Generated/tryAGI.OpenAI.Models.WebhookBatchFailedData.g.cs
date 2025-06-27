
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event data payload.
    /// </summary>
    public sealed partial class WebhookBatchFailedData
    {
        /// <summary>
        /// The unique ID of the batch API request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBatchFailedData" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the batch API request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookBatchFailedData(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBatchFailedData" /> class.
        /// </summary>
        public WebhookBatchFailedData()
        {
        }
    }
}