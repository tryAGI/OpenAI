
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `programmatic_tool_calling`.<br/>
    /// Default Value: programmatic_tool_calling
    /// </summary>
    public enum PersistedAgentToolResourceProgrammaticToolCallingType
    {
        /// <summary>
        ///
        /// </summary>
        ProgrammaticToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedAgentToolResourceProgrammaticToolCallingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedAgentToolResourceProgrammaticToolCallingType value)
        {
            return value switch
            {
                PersistedAgentToolResourceProgrammaticToolCallingType.ProgrammaticToolCalling => "programmatic_tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedAgentToolResourceProgrammaticToolCallingType? ToEnum(string value)
        {
            return value switch
            {
                "programmatic_tool_calling" => PersistedAgentToolResourceProgrammaticToolCallingType.ProgrammaticToolCalling,
                _ => null,
            };
        }
    }
}