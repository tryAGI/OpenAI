
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `periodic`.<br/>
    /// Default Value: periodic
    /// </summary>
    public enum AutomationResourcePeriodicType
    {
        /// <summary>
        ///
        /// </summary>
        Periodic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationResourcePeriodicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationResourcePeriodicType value)
        {
            return value switch
            {
                AutomationResourcePeriodicType.Periodic => "periodic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationResourcePeriodicType? ToEnum(string value)
        {
            return value switch
            {
                "periodic" => AutomationResourcePeriodicType.Periodic,
                _ => null,
            };
        }
    }
}