
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `agent`.<br/>
    /// Default Value: agent
    /// </summary>
    public enum AgentResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResourceObject value)
        {
            return value switch
            {
                AgentResourceObject.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AgentResourceObject.Agent,
                _ => null,
            };
        }
    }
}