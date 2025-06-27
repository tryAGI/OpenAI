
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a completion response from the API. Note: both the streamed and non-streamed response objects share the same shape (unlike the chat endpoint).
    /// </summary>
    public sealed partial class CreateCompletionResponse
    {
        /// <summary>
        /// The list of completion choices the model generated for the input prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateCompletionResponseChoice> Choices { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the completion was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// A unique identifier for the completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The model used for completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The object type, which is always "text_completion"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateCompletionResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.CreateCompletionResponseObject Object { get; set; }

        /// <summary>
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// Usage statistics for the completion request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::tryAGI.OpenAI.CompletionUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionResponse" /> class.
        /// </summary>
        /// <param name="choices">
        /// The list of completion choices the model generated for the input prompt.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp (in seconds) of when the completion was created.
        /// </param>
        /// <param name="id">
        /// A unique identifier for the completion.
        /// </param>
        /// <param name="model">
        /// The model used for completion.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "text_completion"
        /// </param>
        /// <param name="systemFingerprint">
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </param>
        /// <param name="usage">
        /// Usage statistics for the completion request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCompletionResponse(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateCompletionResponseChoice> choices,
            global::System.DateTimeOffset created,
            string id,
            string model,
            global::tryAGI.OpenAI.CreateCompletionResponseObject @object,
            string? systemFingerprint,
            global::tryAGI.OpenAI.CompletionUsage? usage)
        {
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Created = created;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.SystemFingerprint = systemFingerprint;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionResponse" /> class.
        /// </summary>
        public CreateCompletionResponse()
        {
        }
    }
}