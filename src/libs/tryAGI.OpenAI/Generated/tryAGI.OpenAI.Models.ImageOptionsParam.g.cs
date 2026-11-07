
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Request level image options.
    /// </summary>
    public sealed partial class ImageOptionsParam
    {
        /// <summary>
        /// Controls image context optimization. Defaults to `auto`, which uses the model, transport, and input to select a policy. Use `enabled` to require compression support or `disabled` to turn it off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageContextCompressionJsonConverter))]
        public global::tryAGI.OpenAI.ImageContextCompression? ContextCompression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageOptionsParam" /> class.
        /// </summary>
        /// <param name="contextCompression">
        /// Controls image context optimization. Defaults to `auto`, which uses the model, transport, and input to select a policy. Use `enabled` to require compression support or `disabled` to turn it off.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageOptionsParam(
            global::tryAGI.OpenAI.ImageContextCompression? contextCompression)
        {
            this.ContextCompression = contextCompression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageOptionsParam" /> class.
        /// </summary>
        public ImageOptionsParam()
        {
        }

    }
}