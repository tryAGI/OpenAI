
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type for a subagent.<br/>
    /// Default Value: agent.session.subagent
    /// </summary>
    public enum SubagentObjectResource
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionSubagent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubagentObjectResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubagentObjectResource value)
        {
            return value switch
            {
                SubagentObjectResource.AgentSessionSubagent => "agent.session.subagent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubagentObjectResource? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.subagent" => SubagentObjectResource.AgentSessionSubagent,
                _ => null,
            };
        }
    }
}