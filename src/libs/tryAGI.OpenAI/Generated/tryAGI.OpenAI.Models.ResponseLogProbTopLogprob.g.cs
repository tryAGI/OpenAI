
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseLogProbTopLogprob
    {
        /// <summary>
        /// A possible text token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// The log probability of this token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        public double? Logprob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLogProbTopLogprob" /> class.
        /// </summary>
        /// <param name="token">
        /// A possible text token.
        /// </param>
        /// <param name="logprob">
        /// The log probability of this token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseLogProbTopLogprob(
            string? token,
            double? logprob)
        {
            this.Token = token;
            this.Logprob = logprob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLogProbTopLogprob" /> class.
        /// </summary>
        public ResponseLogProbTopLogprob()
        {
        }
    }
}