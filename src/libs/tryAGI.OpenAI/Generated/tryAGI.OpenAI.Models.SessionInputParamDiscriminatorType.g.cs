
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionInputParamDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionInputCancel,
        /// <summary>
        ///
        /// </summary>
        AgentSessionInputMessage,
        /// <summary>
        ///
        /// </summary>
        AgentSessionInputToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionInputParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionInputParamDiscriminatorType value)
        {
            return value switch
            {
                SessionInputParamDiscriminatorType.AgentSessionInputCancel => "agent.session.input.cancel",
                SessionInputParamDiscriminatorType.AgentSessionInputMessage => "agent.session.input.message",
                SessionInputParamDiscriminatorType.AgentSessionInputToolResult => "agent.session.input.tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionInputParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.input.cancel" => SessionInputParamDiscriminatorType.AgentSessionInputCancel,
                "agent.session.input.message" => SessionInputParamDiscriminatorType.AgentSessionInputMessage,
                "agent.session.input.tool_result" => SessionInputParamDiscriminatorType.AgentSessionInputToolResult,
                _ => null,
            };
        }
    }
}