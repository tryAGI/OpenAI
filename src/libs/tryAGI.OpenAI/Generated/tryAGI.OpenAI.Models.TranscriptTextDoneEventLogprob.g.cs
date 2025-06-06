
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptTextDoneEventLogprob
    {
        /// <summary>
        /// The token that was used to generate the log probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// The log probability of the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        public double? Logprob { get; set; }

        /// <summary>
        /// The bytes that were used to generate the log probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public byte[]? Bytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDoneEventLogprob" /> class.
        /// </summary>
        /// <param name="token">
        /// The token that was used to generate the log probability.
        /// </param>
        /// <param name="logprob">
        /// The log probability of the token.
        /// </param>
        /// <param name="bytes">
        /// The bytes that were used to generate the log probability.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptTextDoneEventLogprob(
            string? token,
            double? logprob,
            byte[]? bytes)
        {
            this.Token = token;
            this.Logprob = logprob;
            this.Bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDoneEventLogprob" /> class.
        /// </summary>
        public TranscriptTextDoneEventLogprob()
        {
        }
    }
}