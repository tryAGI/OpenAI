
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents if a given text input is potentially harmful.
    /// </summary>
    public sealed partial class CreateModerationResponse
    {
        /// <summary>
        /// The unique identifier for the moderation request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The model used to generate the moderation results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// A list of moderation objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the moderation request.
        /// </param>
        /// <param name="model">
        /// The model used to generate the moderation results.
        /// </param>
        /// <param name="results">
        /// A list of moderation objects.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateModerationResponse(
            string id,
            string model,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateModerationResponseResult> results)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponse" /> class.
        /// </summary>
        public CreateModerationResponse()
        {
        }
    }
}