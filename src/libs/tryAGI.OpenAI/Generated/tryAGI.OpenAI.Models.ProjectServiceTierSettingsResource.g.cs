
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectServiceTierSettingsResource
    {
        /// <summary>
        /// Default Value: project.service_tier_settings
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceObject.ProjectServiceTierSettings</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceTierSettingsResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceObject Object { get; set; } = global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceObject.ProjectServiceTierSettings;

        /// <summary>
        /// Default tier for requests that omit service_tier or use auto.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectDefaultServiceTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ProjectDefaultServiceTier Default { get; set; }

        /// <summary>
        /// Additional service tiers enabled for this project. "all" includes future tiers. An empty array allows only Standard. Organization policy and eligibility still apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_tiers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceEnabledTiers?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectOptionalServiceTier>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceEnabledTiers?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectOptionalServiceTier>> EnabledTiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceTierSettingsResource" /> class.
        /// </summary>
        /// <param name="default">
        /// Default tier for requests that omit service_tier or use auto.
        /// </param>
        /// <param name="enabledTiers">
        /// Additional service tiers enabled for this project. "all" includes future tiers. An empty array allows only Standard. Organization policy and eligibility still apply.
        /// </param>
        /// <param name="object">
        /// Default Value: project.service_tier_settings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectServiceTierSettingsResource(
            global::tryAGI.OpenAI.ProjectDefaultServiceTier @default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceEnabledTiers?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectOptionalServiceTier>> enabledTiers,
            global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceObject @object = global::tryAGI.OpenAI.ProjectServiceTierSettingsResourceObject.ProjectServiceTierSettings)
        {
            this.Object = @object;
            this.Default = @default;
            this.EnabledTiers = enabledTiers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceTierSettingsResource" /> class.
        /// </summary>
        public ProjectServiceTierSettingsResource()
        {
        }

    }
}