
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `agent.deleted`.<br/>
    /// Default Value: agent.deleted
    /// </summary>
    public enum DeletedAgentResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedAgentResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedAgentResourceObject value)
        {
            return value switch
            {
                DeletedAgentResourceObject.AgentDeleted => "agent.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedAgentResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.deleted" => DeletedAgentResourceObject.AgentDeleted,
                _ => null,
            };
        }
    }
}