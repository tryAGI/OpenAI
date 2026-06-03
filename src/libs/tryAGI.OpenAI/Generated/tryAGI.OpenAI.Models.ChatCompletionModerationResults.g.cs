
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Successful moderation results for the request input or generated output.
    /// </summary>
    public sealed partial class ChatCompletionModerationResults
    {
        /// <summary>
        /// The object type, which is always `moderation_results`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationResultsTypeJsonConverter))]
        public global::tryAGI.OpenAI.ChatCompletionModerationResultsType Type { get; set; }

        /// <summary>
        /// The moderation model used to generate the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// A list of moderation results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationResultBody> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionModerationResults" /> class.
        /// </summary>
        /// <param name="model">
        /// The moderation model used to generate the results.
        /// </param>
        /// <param name="results">
        /// A list of moderation results.
        /// </param>
        /// <param name="type">
        /// The object type, which is always `moderation_results`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionModerationResults(
            string model,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationResultBody> results,
            global::tryAGI.OpenAI.ChatCompletionModerationResultsType type)
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionModerationResults" /> class.
        /// </summary>
        public ChatCompletionModerationResults()
        {
        }

    }
}