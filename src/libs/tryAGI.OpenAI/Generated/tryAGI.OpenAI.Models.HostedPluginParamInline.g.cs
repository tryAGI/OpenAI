
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supplies a plugin ZIP directly in the session request.
    /// </summary>
    public sealed partial class HostedPluginParamInline
    {
        /// <summary>
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedPluginParamInlineType.Inline</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedPluginParamInlineTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedPluginParamInlineType Type { get; set; } = global::tryAGI.OpenAI.HostedPluginParamInlineType.Inline;

        /// <summary>
        /// The plugin name declared in `.codex-plugin/plugin.json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The plugin description declared in `.codex-plugin/plugin.json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The inline ZIP archive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64 Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedPluginParamInline" /> class.
        /// </summary>
        /// <param name="name">
        /// The plugin name declared in `.codex-plugin/plugin.json`.
        /// </param>
        /// <param name="description">
        /// The plugin description declared in `.codex-plugin/plugin.json`.
        /// </param>
        /// <param name="source">
        /// The inline ZIP archive.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedPluginParamInline(
            string name,
            string description,
            global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64 source,
            global::tryAGI.OpenAI.HostedPluginParamInlineType type = global::tryAGI.OpenAI.HostedPluginParamInlineType.Inline)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedPluginParamInline" /> class.
        /// </summary>
        public HostedPluginParamInline()
        {
        }

    }
}