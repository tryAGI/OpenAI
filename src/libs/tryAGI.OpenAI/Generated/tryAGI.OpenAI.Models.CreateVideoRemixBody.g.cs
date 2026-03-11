
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for remixing an existing generated video.
    /// </summary>
    public sealed partial class CreateVideoRemixBody
    {
        /// <summary>
        /// Updated text prompt that directs the remix generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRemixBody" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Updated text prompt that directs the remix generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoRemixBody(
            string prompt)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRemixBody" /> class.
        /// </summary>
        public CreateVideoRemixBody()
        {
        }
    }
}