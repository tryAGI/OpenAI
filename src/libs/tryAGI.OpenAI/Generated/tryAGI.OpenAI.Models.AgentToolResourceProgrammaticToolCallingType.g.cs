
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `programmatic_tool_calling`.<br/>
    /// Default Value: programmatic_tool_calling
    /// </summary>
    public enum AgentToolResourceProgrammaticToolCallingType
    {
        /// <summary>
        ///
        /// </summary>
        ProgrammaticToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolResourceProgrammaticToolCallingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolResourceProgrammaticToolCallingType value)
        {
            return value switch
            {
                AgentToolResourceProgrammaticToolCallingType.ProgrammaticToolCalling => "programmatic_tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolResourceProgrammaticToolCallingType? ToEnum(string value)
        {
            return value switch
            {
                "programmatic_tool_calling" => AgentToolResourceProgrammaticToolCallingType.ProgrammaticToolCalling,
                _ => null,
            };
        }
    }
}