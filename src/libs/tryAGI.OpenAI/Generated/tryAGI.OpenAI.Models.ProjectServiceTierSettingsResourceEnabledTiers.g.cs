
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ProjectServiceTierSettingsResourceEnabledTiers
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectServiceTierSettingsResourceEnabledTiersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectServiceTierSettingsResourceEnabledTiers value)
        {
            return value switch
            {
                ProjectServiceTierSettingsResourceEnabledTiers.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectServiceTierSettingsResourceEnabledTiers? ToEnum(string value)
        {
            return value switch
            {
                "all" => ProjectServiceTierSettingsResourceEnabledTiers.All,
                _ => null,
            };
        }
    }
}