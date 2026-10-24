
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `automations`.<br/>
    /// Default Value: automations
    /// </summary>
    public enum PersistedAgentToolResourceAutomationsType
    {
        /// <summary>
        ///
        /// </summary>
        Automations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedAgentToolResourceAutomationsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedAgentToolResourceAutomationsType value)
        {
            return value switch
            {
                PersistedAgentToolResourceAutomationsType.Automations => "automations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedAgentToolResourceAutomationsType? ToEnum(string value)
        {
            return value switch
            {
                "automations" => PersistedAgentToolResourceAutomationsType.Automations,
                _ => null,
            };
        }
    }
}