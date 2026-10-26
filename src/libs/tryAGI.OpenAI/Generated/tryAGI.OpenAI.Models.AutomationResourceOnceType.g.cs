
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `once`.<br/>
    /// Default Value: once
    /// </summary>
    public enum AutomationResourceOnceType
    {
        /// <summary>
        ///
        /// </summary>
        Once,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationResourceOnceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationResourceOnceType value)
        {
            return value switch
            {
                AutomationResourceOnceType.Once => "once",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationResourceOnceType? ToEnum(string value)
        {
            return value switch
            {
                "once" => AutomationResourceOnceType.Once,
                _ => null,
            };
        }
    }
}