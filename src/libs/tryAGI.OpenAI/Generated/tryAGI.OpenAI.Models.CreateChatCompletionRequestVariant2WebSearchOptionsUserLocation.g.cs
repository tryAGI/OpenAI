
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Approximate location parameters for the search.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation
    {
        /// <summary>
        /// The type of location approximation. Always `approximate`.
        /// </summary>
        /// <default>"approximate"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "approximate";

        /// <summary>
        /// Approximate location parameters for the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approximate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebSearchLocation Approximate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation" /> class.
        /// </summary>
        /// <param name="approximate">
        /// Approximate location parameters for the search.
        /// </param>
        /// <param name="type">
        /// The type of location approximation. Always `approximate`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation(
            global::tryAGI.OpenAI.WebSearchLocation approximate,
            string type = "approximate")
        {
            this.Type = type;
            this.Approximate = approximate ?? throw new global::System.ArgumentNullException(nameof(approximate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation" /> class.
        /// </summary>
        public CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation FromApproximate(global::tryAGI.OpenAI.WebSearchLocation approximate)
        {
            return new CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation
            {
                Approximate = approximate,
            };
        }

    }
}