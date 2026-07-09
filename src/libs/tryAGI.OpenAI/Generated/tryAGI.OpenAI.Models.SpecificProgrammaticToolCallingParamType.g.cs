
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `programmatic_tool_calling`.<br/>
    /// Default Value: programmatic_tool_calling
    /// </summary>
    public enum SpecificProgrammaticToolCallingParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ProgrammaticToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpecificProgrammaticToolCallingParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpecificProgrammaticToolCallingParamType value)
        {
            return value switch
            {
                SpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling => "programmatic_tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpecificProgrammaticToolCallingParamType? ToEnum(string value)
        {
            return value switch
            {
                "programmatic_tool_calling" => SpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling,
                _ => null,
            };
        }
    }
}