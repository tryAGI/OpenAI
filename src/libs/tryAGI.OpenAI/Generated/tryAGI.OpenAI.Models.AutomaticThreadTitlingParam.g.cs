
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls whether ChatKit automatically generates thread titles.
    /// </summary>
    public sealed partial class AutomaticThreadTitlingParam
    {
        /// <summary>
        /// Enable automatic thread title generation. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticThreadTitlingParam" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enable automatic thread title generation. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomaticThreadTitlingParam(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticThreadTitlingParam" /> class.
        /// </summary>
        public AutomaticThreadTitlingParam()
        {
        }
    }
}