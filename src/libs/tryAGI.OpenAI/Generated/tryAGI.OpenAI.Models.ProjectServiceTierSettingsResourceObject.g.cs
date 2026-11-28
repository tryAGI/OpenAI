
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: project.service_tier_settings
    /// </summary>
    public enum ProjectServiceTierSettingsResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        ProjectServiceTierSettings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectServiceTierSettingsResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectServiceTierSettingsResourceObject value)
        {
            return value switch
            {
                ProjectServiceTierSettingsResourceObject.ProjectServiceTierSettings => "project.service_tier_settings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectServiceTierSettingsResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "project.service_tier_settings" => ProjectServiceTierSettingsResourceObject.ProjectServiceTierSettings,
                _ => null,
            };
        }
    }
}