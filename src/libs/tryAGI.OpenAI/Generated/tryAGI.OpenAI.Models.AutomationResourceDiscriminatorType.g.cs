
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AutomationResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Once,
        /// <summary>
        ///
        /// </summary>
        Periodic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationResourceDiscriminatorType value)
        {
            return value switch
            {
                AutomationResourceDiscriminatorType.Once => "once",
                AutomationResourceDiscriminatorType.Periodic => "periodic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "once" => AutomationResourceDiscriminatorType.Once,
                "periodic" => AutomationResourceDiscriminatorType.Periodic,
                _ => null,
            };
        }
    }
}