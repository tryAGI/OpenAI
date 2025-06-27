
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranscriptionResponseJsonLogprob
    {
        /// <summary>
        /// The bytes of the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public global::System.Collections.Generic.IList<double>? Bytes { get; set; }

        /// <summary>
        /// The log probability of the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        public double? Logprob { get; set; }

        /// <summary>
        /// The token in the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseJsonLogprob" /> class.
        /// </summary>
        /// <param name="bytes">
        /// The bytes of the token.
        /// </param>
        /// <param name="logprob">
        /// The log probability of the token.
        /// </param>
        /// <param name="token">
        /// The token in the transcription.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranscriptionResponseJsonLogprob(
            global::System.Collections.Generic.IList<double>? bytes,
            double? logprob,
            string? token)
        {
            this.Bytes = bytes;
            this.Logprob = logprob;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseJsonLogprob" /> class.
        /// </summary>
        public CreateTranscriptionResponseJsonLogprob()
        {
        }
    }
}