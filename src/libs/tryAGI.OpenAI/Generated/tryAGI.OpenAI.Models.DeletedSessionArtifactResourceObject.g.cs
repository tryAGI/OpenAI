
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `agent.session.artifact.deleted`.<br/>
    /// Default Value: agent.session.artifact.deleted
    /// </summary>
    public enum DeletedSessionArtifactResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionArtifactDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedSessionArtifactResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedSessionArtifactResourceObject value)
        {
            return value switch
            {
                DeletedSessionArtifactResourceObject.AgentSessionArtifactDeleted => "agent.session.artifact.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedSessionArtifactResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.artifact.deleted" => DeletedSessionArtifactResourceObject.AgentSessionArtifactDeleted,
                _ => null,
            };
        }
    }
}