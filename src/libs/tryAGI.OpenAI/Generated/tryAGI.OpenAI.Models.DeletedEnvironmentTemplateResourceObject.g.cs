
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `agent.environment.template.deleted`.<br/>
    /// Default Value: agent.environment.template.deleted
    /// </summary>
    public enum DeletedEnvironmentTemplateResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentEnvironmentTemplateDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedEnvironmentTemplateResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedEnvironmentTemplateResourceObject value)
        {
            return value switch
            {
                DeletedEnvironmentTemplateResourceObject.AgentEnvironmentTemplateDeleted => "agent.environment.template.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedEnvironmentTemplateResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.environment.template.deleted" => DeletedEnvironmentTemplateResourceObject.AgentEnvironmentTemplateDeleted,
                _ => null,
            };
        }
    }
}