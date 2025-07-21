
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseLogProbTopLogprob
    {
        /// <summary>
        /// The log probability of this token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        public double? Logprob { get; set; }

        /// <summary>
        /// A possible text token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLogProbTopLogprob" /> class.
        /// </summary>
        /// <param name="logprob">
        /// The log probability of this token.
        /// </param>
        /// <param name="token">
        /// A possible text token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseLogProbTopLogprob(
            double? logprob,
            string? token)
        {
            this.Logprob = logprob;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLogProbTopLogprob" /> class.
        /// </summary>
        public ResponseLogProbTopLogprob()
        {
        }
    }
}