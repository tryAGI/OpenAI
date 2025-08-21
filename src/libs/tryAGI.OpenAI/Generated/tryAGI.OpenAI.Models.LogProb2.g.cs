
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogProb2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Bytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb2> TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogProb2" /> class.
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="logprob"></param>
        /// <param name="token"></param>
        /// <param name="topLogprobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogProb2(
            global::System.Collections.Generic.IList<int> bytes,
            double logprob,
            string token,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb2> topLogprobs)
        {
            this.Bytes = bytes ?? throw new global::System.ArgumentNullException(nameof(bytes));
            this.Logprob = logprob;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.TopLogprobs = topLogprobs ?? throw new global::System.ArgumentNullException(nameof(topLogprobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogProb2" /> class.
        /// </summary>
        public LogProb2()
        {
        }
    }
}