
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a streamed chunk of a chat completion response returned<br/>
    /// by the model, based on the provided input. <br/>
    /// [Learn more](/docs/guides/streaming-responses).
    /// </summary>
    public sealed partial class CreateChatCompletionStreamResponse
    {
        /// <summary>
        /// A unique identifier for the chat completion. Each chunk has the same ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A list of chat completion choices. Can contain more than one elements if `n` is greater than 1. Can also be empty for the<br/>
        /// last chunk if you set `stream_options: {"include_usage": true}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice> Choices { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the chat completion was created. Each chunk has the same timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// The model to generate the completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The service tier used for processing the request.<br/>
        /// Example: scale
        /// </summary>
        /// <example>scale</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseServiceTierJsonConverter))]
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// The object type, which is always `chat.completion.chunk`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject Object { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the chat completion. Each chunk has the same ID.
        /// </param>
        /// <param name="choices">
        /// A list of chat completion choices. Can contain more than one elements if `n` is greater than 1. Can also be empty for the<br/>
        /// last chunk if you set `stream_options: {"include_usage": true}`.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp (in seconds) of when the chat completion was created. Each chunk has the same timestamp.
        /// </param>
        /// <param name="model">
        /// The model to generate the completion.
        /// </param>
        /// <param name="serviceTier">
        /// The service tier used for processing the request.<br/>
        /// Example: scale
        /// </param>
        /// <param name="systemFingerprint">
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `chat.completion.chunk`.
        /// </param>
        /// <param name="usage">
        /// Usage statistics for the completion request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionStreamResponse(
            string id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice> choices,
            global::System.DateTimeOffset created,
            string model,
            global::tryAGI.OpenAI.CreateChatCompletionStreamResponseServiceTier? serviceTier,
            string? systemFingerprint,
            global::tryAGI.OpenAI.CreateChatCompletionStreamResponseObject @object,
            global::tryAGI.OpenAI.CompletionUsage? usage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ServiceTier = serviceTier;
            this.SystemFingerprint = systemFingerprint;
            this.Object = @object;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponse" /> class.
        /// </summary>
        public CreateChatCompletionStreamResponse()
        {
        }
    }
}