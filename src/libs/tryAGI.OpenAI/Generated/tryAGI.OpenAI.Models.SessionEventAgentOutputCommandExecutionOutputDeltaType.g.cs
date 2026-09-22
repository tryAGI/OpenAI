
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.output.command_execution_output.delta`.<br/>
    /// Default Value: agent.output.command_execution_output.delta
    /// </summary>
    public enum SessionEventAgentOutputCommandExecutionOutputDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        AgentOutputCommandExecutionOutputDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentOutputCommandExecutionOutputDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentOutputCommandExecutionOutputDeltaType value)
        {
            return value switch
            {
                SessionEventAgentOutputCommandExecutionOutputDeltaType.AgentOutputCommandExecutionOutputDelta => "agent.output.command_execution_output.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentOutputCommandExecutionOutputDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "agent.output.command_execution_output.delta" => SessionEventAgentOutputCommandExecutionOutputDeltaType.AgentOutputCommandExecutionOutputDelta,
                _ => null,
            };
        }
    }
}