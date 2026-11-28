
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.budget_reached`.<br/>
    /// Default Value: agent.session.budget_reached
    /// </summary>
    public enum SessionEventAgentSessionBudgetReachedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionBudgetReached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionBudgetReachedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionBudgetReachedType value)
        {
            return value switch
            {
                SessionEventAgentSessionBudgetReachedType.AgentSessionBudgetReached => "agent.session.budget_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionBudgetReachedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.budget_reached" => SessionEventAgentSessionBudgetReachedType.AgentSessionBudgetReached,
                _ => null,
            };
        }
    }
}