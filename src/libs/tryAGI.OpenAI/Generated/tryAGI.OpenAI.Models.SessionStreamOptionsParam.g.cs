
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Options for a Managed Agents session event stream.
    /// </summary>
    public sealed partial class SessionStreamOptionsParam
    {
        /// <summary>
        /// Whether to include obfuscation padding in events on this connection. Defaults to `true`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_obfuscation")]
        public bool? IncludeObfuscation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionStreamOptionsParam" /> class.
        /// </summary>
        /// <param name="includeObfuscation">
        /// Whether to include obfuscation padding in events on this connection. Defaults to `true`.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionStreamOptionsParam(
            bool? includeObfuscation)
        {
            this.IncludeObfuscation = includeObfuscation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionStreamOptionsParam" /> class.
        /// </summary>
        public SessionStreamOptionsParam()
        {
        }

    }
}