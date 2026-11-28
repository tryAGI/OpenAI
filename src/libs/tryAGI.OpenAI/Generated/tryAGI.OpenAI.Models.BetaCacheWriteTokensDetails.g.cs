
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCacheWriteTokensDetails
    {
        /// <summary>
        /// The number of input tokens written with 30-minute retention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_30m_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Ttl30mTokens { get; set; }

        /// <summary>
        /// The number of input tokens written with 12-hour retention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_12h_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Ttl12hTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCacheWriteTokensDetails" /> class.
        /// </summary>
        /// <param name="ttl30mTokens">
        /// The number of input tokens written with 30-minute retention.
        /// </param>
        /// <param name="ttl12hTokens">
        /// The number of input tokens written with 12-hour retention.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCacheWriteTokensDetails(
            int ttl30mTokens,
            int ttl12hTokens)
        {
            this.Ttl30mTokens = ttl30mTokens;
            this.Ttl12hTokens = ttl12hTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCacheWriteTokensDetails" /> class.
        /// </summary>
        public BetaCacheWriteTokensDetails()
        {
        }

    }
}