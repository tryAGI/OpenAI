
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `agent.session.deleted`.<br/>
    /// Default Value: agent.session.deleted
    /// </summary>
    public enum DeletedSessionResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedSessionResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedSessionResourceObject value)
        {
            return value switch
            {
                DeletedSessionResourceObject.AgentSessionDeleted => "agent.session.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedSessionResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.deleted" => DeletedSessionResourceObject.AgentSessionDeleted,
                _ => null,
            };
        }
    }
}