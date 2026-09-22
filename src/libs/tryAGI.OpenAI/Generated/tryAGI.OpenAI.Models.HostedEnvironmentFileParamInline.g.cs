
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A file supplied directly as standard-base64 data.
    /// </summary>
    public sealed partial class HostedEnvironmentFileParamInline
    {
        /// <summary>
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType.Inline</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamInlineTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType Type { get; set; } = global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType.Inline;

        /// <summary>
        /// The standard-base64-encoded file contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The absolute destination path inside `/workspace`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedEnvironmentFileParamInline" /> class.
        /// </summary>
        /// <param name="data">
        /// The standard-base64-encoded file contents.
        /// </param>
        /// <param name="path">
        /// The absolute destination path inside `/workspace`.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedEnvironmentFileParamInline(
            string data,
            string path,
            global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType type = global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType.Inline)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedEnvironmentFileParamInline" /> class.
        /// </summary>
        public HostedEnvironmentFileParamInline()
        {
        }

    }
}