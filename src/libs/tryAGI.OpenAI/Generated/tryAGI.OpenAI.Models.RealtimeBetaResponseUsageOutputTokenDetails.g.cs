
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details about the output tokens used in the Response.
    /// </summary>
    public sealed partial class RealtimeBetaResponseUsageOutputTokenDetails
    {
        /// <summary>
        /// The number of audio tokens used in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// The number of text tokens used in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaResponseUsageOutputTokenDetails" /> class.
        /// </summary>
        /// <param name="audioTokens">
        /// The number of audio tokens used in the Response.
        /// </param>
        /// <param name="textTokens">
        /// The number of text tokens used in the Response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaResponseUsageOutputTokenDetails(
            int? audioTokens,
            int? textTokens)
        {
            this.AudioTokens = audioTokens;
            this.TextTokens = textTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaResponseUsageOutputTokenDetails" /> class.
        /// </summary>
        public RealtimeBetaResponseUsageOutputTokenDetails()
        {
        }
    }
}