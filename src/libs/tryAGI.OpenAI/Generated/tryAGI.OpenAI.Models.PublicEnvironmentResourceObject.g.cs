
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `agent.environment`.<br/>
    /// Default Value: agent.environment
    /// </summary>
    public enum PublicEnvironmentResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentEnvironment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicEnvironmentResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicEnvironmentResourceObject value)
        {
            return value switch
            {
                PublicEnvironmentResourceObject.AgentEnvironment => "agent.environment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicEnvironmentResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.environment" => PublicEnvironmentResourceObject.AgentEnvironment,
                _ => null,
            };
        }
    }
}