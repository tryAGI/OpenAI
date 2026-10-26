
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `developer`.<br/>
    /// Default Value: developer
    /// </summary>
    public enum AutomationCreatedByResourceDeveloperType
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationCreatedByResourceDeveloperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationCreatedByResourceDeveloperType value)
        {
            return value switch
            {
                AutomationCreatedByResourceDeveloperType.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationCreatedByResourceDeveloperType? ToEnum(string value)
        {
            return value switch
            {
                "developer" => AutomationCreatedByResourceDeveloperType.Developer,
                _ => null,
            };
        }
    }
}