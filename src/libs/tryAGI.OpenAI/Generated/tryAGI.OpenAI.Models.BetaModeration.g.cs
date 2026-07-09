
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Moderation results or errors for the response input and output.
    /// </summary>
    public sealed partial class BetaModeration
    {
        /// <summary>
        /// Moderation for the response input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.Input5JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Input5 Input { get; set; }

        /// <summary>
        /// Moderation for the response output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.Output9JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Output9 Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaModeration" /> class.
        /// </summary>
        /// <param name="input">
        /// Moderation for the response input.
        /// </param>
        /// <param name="output">
        /// Moderation for the response output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaModeration(
            global::tryAGI.OpenAI.Input5 input,
            global::tryAGI.OpenAI.Output9 output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaModeration" /> class.
        /// </summary>
        public BetaModeration()
        {
        }

    }
}