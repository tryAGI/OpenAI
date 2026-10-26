
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `agent.automation`.<br/>
    /// Default Value: agent.automation
    /// </summary>
    public enum AutomationResourcePeriodicObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentAutomation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationResourcePeriodicObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationResourcePeriodicObject value)
        {
            return value switch
            {
                AutomationResourcePeriodicObject.AgentAutomation => "agent.automation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationResourcePeriodicObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.automation" => AutomationResourcePeriodicObject.AgentAutomation,
                _ => null,
            };
        }
    }
}