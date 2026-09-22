
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `agent.session.artifact`.<br/>
    /// Default Value: agent.session.artifact
    /// </summary>
    public enum SessionArtifactResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionArtifact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionArtifactResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionArtifactResourceObject value)
        {
            return value switch
            {
                SessionArtifactResourceObject.AgentSessionArtifact => "agent.session.artifact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionArtifactResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.artifact" => SessionArtifactResourceObject.AgentSessionArtifact,
                _ => null,
            };
        }
    }
}