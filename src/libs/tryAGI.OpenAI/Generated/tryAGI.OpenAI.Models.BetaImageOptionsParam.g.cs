
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Request level image options.
    /// </summary>
    public sealed partial class BetaImageOptionsParam
    {
        /// <summary>
        /// Controls image context optimization. Defaults to `auto`, which uses the model, transport, and input to select a policy. Use `enabled` to require compression support or `disabled` to turn it off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaImageContextCompressionJsonConverter))]
        public global::tryAGI.OpenAI.BetaImageContextCompression? ContextCompression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaImageOptionsParam" /> class.
        /// </summary>
        /// <param name="contextCompression">
        /// Controls image context optimization. Defaults to `auto`, which uses the model, transport, and input to select a policy. Use `enabled` to require compression support or `disabled` to turn it off.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaImageOptionsParam(
            global::tryAGI.OpenAI.BetaImageContextCompression? contextCompression)
        {
            this.ContextCompression = contextCompression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaImageOptionsParam" /> class.
        /// </summary>
        public BetaImageOptionsParam()
        {
        }

    }
}