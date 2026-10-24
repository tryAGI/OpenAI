
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AutomationCreatedByResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationCreatedByResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationCreatedByResourceDiscriminatorType value)
        {
            return value switch
            {
                AutomationCreatedByResourceDiscriminatorType.Agent => "agent",
                AutomationCreatedByResourceDiscriminatorType.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationCreatedByResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AutomationCreatedByResourceDiscriminatorType.Agent,
                "developer" => AutomationCreatedByResourceDiscriminatorType.Developer,
                _ => null,
            };
        }
    }
}