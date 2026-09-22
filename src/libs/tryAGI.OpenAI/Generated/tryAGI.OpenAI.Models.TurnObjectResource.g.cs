
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type for a turn.<br/>
    /// Default Value: agent.session.turn
    /// </summary>
    public enum TurnObjectResource
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurnObjectResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurnObjectResource value)
        {
            return value switch
            {
                TurnObjectResource.AgentSessionTurn => "agent.session.turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurnObjectResource? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn" => TurnObjectResource.AgentSessionTurn,
                _ => null,
            };
        }
    }
}