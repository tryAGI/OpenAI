
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `agent.automation`.<br/>
    /// Default Value: agent.automation
    /// </summary>
    public enum AutomationResourceOnceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentAutomation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationResourceOnceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationResourceOnceObject value)
        {
            return value switch
            {
                AutomationResourceOnceObject.AgentAutomation => "agent.automation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationResourceOnceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.automation" => AutomationResourceOnceObject.AgentAutomation,
                _ => null,
            };
        }
    }
}