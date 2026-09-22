
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `agent.environment.file`.<br/>
    /// Default Value: agent.environment.file
    /// </summary>
    public enum EnvironmentFileResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentEnvironmentFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentFileResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentFileResourceObject value)
        {
            return value switch
            {
                EnvironmentFileResourceObject.AgentEnvironmentFile => "agent.environment.file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentFileResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.environment.file" => EnvironmentFileResourceObject.AgentEnvironmentFile,
                _ => null,
            };
        }
    }
}