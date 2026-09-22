
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `agent.environment.template`.<br/>
    /// Default Value: agent.environment.template
    /// </summary>
    public enum EnvironmentTemplateResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentEnvironmentTemplate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentTemplateResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentTemplateResourceObject value)
        {
            return value switch
            {
                EnvironmentTemplateResourceObject.AgentEnvironmentTemplate => "agent.environment.template",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentTemplateResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.environment.template" => EnvironmentTemplateResourceObject.AgentEnvironmentTemplate,
                _ => null,
            };
        }
    }
}