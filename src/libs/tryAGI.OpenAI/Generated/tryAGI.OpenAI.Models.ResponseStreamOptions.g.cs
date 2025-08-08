
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Options for streaming responses. Only set this when you set `stream: true`.
    /// </summary>
    public sealed partial class ResponseStreamOptions
    {
        /// <summary>
        /// When true, stream obfuscation will be enabled. Stream obfuscation adds<br/>
        /// random characters to an `obfuscation` field on streaming delta events to<br/>
        /// normalize payload sizes as a mitigation to certain side-channel attacks.<br/>
        /// These obfuscation fields are included by default, but add a small amount<br/>
        /// of overhead to the data stream. You can set `include_obfuscation` to<br/>
        /// false to optimize for bandwidth if you trust the network links between<br/>
        /// your application and the OpenAI API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_obfuscation")]
        public bool? IncludeObfuscation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamOptions" /> class.
        /// </summary>
        /// <param name="includeObfuscation">
        /// When true, stream obfuscation will be enabled. Stream obfuscation adds<br/>
        /// random characters to an `obfuscation` field on streaming delta events to<br/>
        /// normalize payload sizes as a mitigation to certain side-channel attacks.<br/>
        /// These obfuscation fields are included by default, but add a small amount<br/>
        /// of overhead to the data stream. You can set `include_obfuscation` to<br/>
        /// false to optimize for bandwidth if you trust the network links between<br/>
        /// your application and the OpenAI API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamOptions(
            bool? includeObfuscation)
        {
            this.IncludeObfuscation = includeObfuscation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamOptions" /> class.
        /// </summary>
        public ResponseStreamOptions()
        {
        }
    }
}