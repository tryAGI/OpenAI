
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A log probability object.
    /// </summary>
    public sealed partial class LogProbProperties
    {
        /// <summary>
        /// The bytes that were used to generate the log probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Bytes { get; set; }

        /// <summary>
        /// The log probability of the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// The token that was used to generate the log probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogProbProperties" /> class.
        /// </summary>
        /// <param name="bytes">
        /// The bytes that were used to generate the log probability.
        /// </param>
        /// <param name="logprob">
        /// The log probability of the token.
        /// </param>
        /// <param name="token">
        /// The token that was used to generate the log probability.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogProbProperties(
            global::System.Collections.Generic.IList<int> bytes,
            double logprob,
            string token)
        {
            this.Bytes = bytes ?? throw new global::System.ArgumentNullException(nameof(bytes));
            this.Logprob = logprob;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogProbProperties" /> class.
        /// </summary>
        public LogProbProperties()
        {
        }
    }
}