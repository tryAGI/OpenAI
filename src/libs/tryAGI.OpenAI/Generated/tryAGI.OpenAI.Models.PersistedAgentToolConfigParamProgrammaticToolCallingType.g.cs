
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `programmatic_tool_calling`.<br/>
    /// Default Value: programmatic_tool_calling
    /// </summary>
    public enum PersistedAgentToolConfigParamProgrammaticToolCallingType
    {
        /// <summary>
        ///
        /// </summary>
        ProgrammaticToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedAgentToolConfigParamProgrammaticToolCallingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedAgentToolConfigParamProgrammaticToolCallingType value)
        {
            return value switch
            {
                PersistedAgentToolConfigParamProgrammaticToolCallingType.ProgrammaticToolCalling => "programmatic_tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedAgentToolConfigParamProgrammaticToolCallingType? ToEnum(string value)
        {
            return value switch
            {
                "programmatic_tool_calling" => PersistedAgentToolConfigParamProgrammaticToolCallingType.ProgrammaticToolCalling,
                _ => null,
            };
        }
    }
}