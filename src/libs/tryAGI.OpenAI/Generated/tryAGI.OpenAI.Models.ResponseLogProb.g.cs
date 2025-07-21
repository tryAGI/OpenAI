
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A logprob is the logarithmic probability that the model assigns to producing <br/>
    /// a particular token at a given position in the sequence. Less-negative (higher) <br/>
    /// logprob values indicate greater model confidence in that token choice.
    /// </summary>
    public sealed partial class ResponseLogProb
    {
        /// <summary>
        /// The log probability of this token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// A possible text token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// The log probability of the top 20 most likely tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>? TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLogProb" /> class.
        /// </summary>
        /// <param name="logprob">
        /// The log probability of this token.
        /// </param>
        /// <param name="token">
        /// A possible text token.
        /// </param>
        /// <param name="topLogprobs">
        /// The log probability of the top 20 most likely tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseLogProb(
            double logprob,
            string token,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>? topLogprobs)
        {
            this.Logprob = logprob;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.TopLogprobs = topLogprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLogProb" /> class.
        /// </summary>
        public ResponseLogProb()
        {
        }
    }
}