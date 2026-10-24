
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `none`.<br/>
    /// Default Value: none
    /// </summary>
    public enum AutomationEnvironmentResourceNoneType
    {
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationEnvironmentResourceNoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationEnvironmentResourceNoneType value)
        {
            return value switch
            {
                AutomationEnvironmentResourceNoneType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationEnvironmentResourceNoneType? ToEnum(string value)
        {
            return value switch
            {
                "none" => AutomationEnvironmentResourceNoneType.None,
                _ => null,
            };
        }
    }
}