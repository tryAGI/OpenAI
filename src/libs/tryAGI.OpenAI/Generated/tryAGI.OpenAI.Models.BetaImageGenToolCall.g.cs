
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An image generation request made by the model.
    /// </summary>
    public sealed partial class BetaImageGenToolCall
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the image generation call. Always `image_generation_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaImageGenToolCallType Type { get; set; }

        /// <summary>
        /// The unique ID of the image generation call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the image generation call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaImageGenToolCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaImageGenToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the image generation call.
        /// </param>
        /// <param name="status">
        /// The status of the image generation call.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the image generation call. Always `image_generation_call`.
        /// </param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaImageGenToolCall(
            string id,
            global::tryAGI.OpenAI.BetaImageGenToolCallStatus status,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaImageGenToolCallType type,
            string? result)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaImageGenToolCall" /> class.
        /// </summary>
        public BetaImageGenToolCall()
        {
        }

    }
}