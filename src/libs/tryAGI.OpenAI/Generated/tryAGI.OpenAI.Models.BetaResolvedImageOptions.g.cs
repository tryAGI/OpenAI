
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaResolvedImageOptions
    {
        /// <summary>
        /// Effective image context optimization policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResolvedImageContextCompressionEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaResolvedImageContextCompressionEnum ContextCompression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResolvedImageOptions" /> class.
        /// </summary>
        /// <param name="contextCompression">
        /// Effective image context optimization policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResolvedImageOptions(
            global::tryAGI.OpenAI.BetaResolvedImageContextCompressionEnum contextCompression)
        {
            this.ContextCompression = contextCompression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResolvedImageOptions" /> class.
        /// </summary>
        public BetaResolvedImageOptions()
        {
        }

    }
}