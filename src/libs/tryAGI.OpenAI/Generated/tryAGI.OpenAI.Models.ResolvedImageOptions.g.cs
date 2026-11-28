
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResolvedImageOptions
    {
        /// <summary>
        /// Effective image context optimization policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResolvedImageContextCompressionEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ResolvedImageContextCompressionEnum ContextCompression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolvedImageOptions" /> class.
        /// </summary>
        /// <param name="contextCompression">
        /// Effective image context optimization policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResolvedImageOptions(
            global::tryAGI.OpenAI.ResolvedImageContextCompressionEnum contextCompression)
        {
            this.ContextCompression = contextCompression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolvedImageOptions" /> class.
        /// </summary>
        public ResolvedImageOptions()
        {
        }

    }
}