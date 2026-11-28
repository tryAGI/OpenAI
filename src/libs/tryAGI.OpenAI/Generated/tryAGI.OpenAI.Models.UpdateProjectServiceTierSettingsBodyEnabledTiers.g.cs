
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum UpdateProjectServiceTierSettingsBodyEnabledTiers
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectServiceTierSettingsBodyEnabledTiersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectServiceTierSettingsBodyEnabledTiers value)
        {
            return value switch
            {
                UpdateProjectServiceTierSettingsBodyEnabledTiers.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectServiceTierSettingsBodyEnabledTiers? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectServiceTierSettingsBodyEnabledTiers.All,
                _ => null,
            };
        }
    }
}