
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionTokenLogprob
    {
        /// <summary>
        /// The token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// The log probability of this token, if it is within the top 20 most likely tokens. Otherwise, the value `-9999.0` is used to signify that the token is very unlikely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public global::System.Collections.Generic.IList<long>? Bytes { get; set; }

        /// <summary>
        /// List of the most likely tokens and their log probability, at this token position. In rare cases, there may be fewer than the number of requested `top_logprobs` returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob> TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTokenLogprob" /> class.
        /// </summary>
        /// <param name="token">
        /// The token.
        /// </param>
        /// <param name="logprob">
        /// The log probability of this token, if it is within the top 20 most likely tokens. Otherwise, the value `-9999.0` is used to signify that the token is very unlikely.
        /// </param>
        /// <param name="bytes"></param>
        /// <param name="topLogprobs">
        /// List of the most likely tokens and their log probability, at this token position. In rare cases, there may be fewer than the number of requested `top_logprobs` returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionTokenLogprob(
            string token,
            double logprob,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob> topLogprobs,
            global::System.Collections.Generic.IList<long>? bytes)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Logprob = logprob;
            this.TopLogprobs = topLogprobs ?? throw new global::System.ArgumentNullException(nameof(topLogprobs));
            this.Bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTokenLogprob" /> class.
        /// </summary>
        public ChatCompletionTokenLogprob()
        {
        }
    }
}