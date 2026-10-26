
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `manual`.<br/>
    /// Default Value: manual
    /// </summary>
    public enum AutomationInvocationSourceResourceManualType
    {
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationInvocationSourceResourceManualTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationInvocationSourceResourceManualType value)
        {
            return value switch
            {
                AutomationInvocationSourceResourceManualType.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationInvocationSourceResourceManualType? ToEnum(string value)
        {
            return value switch
            {
                "manual" => AutomationInvocationSourceResourceManualType.Manual,
                _ => null,
            };
        }
    }
}