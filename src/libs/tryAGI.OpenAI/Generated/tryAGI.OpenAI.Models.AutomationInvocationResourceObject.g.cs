
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `agent.automation.invocation`.<br/>
    /// Default Value: agent.automation.invocation
    /// </summary>
    public enum AutomationInvocationResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentAutomationInvocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationInvocationResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationInvocationResourceObject value)
        {
            return value switch
            {
                AutomationInvocationResourceObject.AgentAutomationInvocation => "agent.automation.invocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationInvocationResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.automation.invocation" => AutomationInvocationResourceObject.AgentAutomationInvocation,
                _ => null,
            };
        }
    }
}