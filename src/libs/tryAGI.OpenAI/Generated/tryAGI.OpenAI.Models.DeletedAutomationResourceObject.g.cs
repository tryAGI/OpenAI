
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `agent.automation.deleted`.<br/>
    /// Default Value: agent.automation.deleted
    /// </summary>
    public enum DeletedAutomationResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentAutomationDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedAutomationResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedAutomationResourceObject value)
        {
            return value switch
            {
                DeletedAutomationResourceObject.AgentAutomationDeleted => "agent.automation.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedAutomationResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.automation.deleted" => DeletedAutomationResourceObject.AgentAutomationDeleted,
                _ => null,
            };
        }
    }
}