
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent`.<br/>
    /// Default Value: agent
    /// </summary>
    public enum AutomationCreatedByResourceAgentType
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationCreatedByResourceAgentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationCreatedByResourceAgentType value)
        {
            return value switch
            {
                AutomationCreatedByResourceAgentType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationCreatedByResourceAgentType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AutomationCreatedByResourceAgentType.Agent,
                _ => null,
            };
        }
    }
}