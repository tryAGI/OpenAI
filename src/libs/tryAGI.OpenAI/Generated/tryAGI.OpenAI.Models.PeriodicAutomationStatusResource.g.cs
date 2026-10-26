
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PeriodicAutomationStatusResource
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PeriodicAutomationStatusResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PeriodicAutomationStatusResource value)
        {
            return value switch
            {
                PeriodicAutomationStatusResource.Active => "active",
                PeriodicAutomationStatusResource.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PeriodicAutomationStatusResource? ToEnum(string value)
        {
            return value switch
            {
                "active" => PeriodicAutomationStatusResource.Active,
                "paused" => PeriodicAutomationStatusResource.Paused,
                _ => null,
            };
        }
    }
}