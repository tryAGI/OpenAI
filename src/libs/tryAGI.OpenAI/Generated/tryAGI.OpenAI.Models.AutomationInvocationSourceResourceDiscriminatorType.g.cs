
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AutomationInvocationSourceResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Automation,
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationInvocationSourceResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationInvocationSourceResourceDiscriminatorType value)
        {
            return value switch
            {
                AutomationInvocationSourceResourceDiscriminatorType.Automation => "automation",
                AutomationInvocationSourceResourceDiscriminatorType.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationInvocationSourceResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "automation" => AutomationInvocationSourceResourceDiscriminatorType.Automation,
                "manual" => AutomationInvocationSourceResourceDiscriminatorType.Manual,
                _ => null,
            };
        }
    }
}