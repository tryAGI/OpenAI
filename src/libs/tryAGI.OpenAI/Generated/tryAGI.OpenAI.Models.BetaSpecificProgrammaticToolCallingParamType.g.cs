
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `programmatic_tool_calling`.<br/>
    /// Default Value: programmatic_tool_calling
    /// </summary>
    public enum BetaSpecificProgrammaticToolCallingParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ProgrammaticToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSpecificProgrammaticToolCallingParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpecificProgrammaticToolCallingParamType value)
        {
            return value switch
            {
                BetaSpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling => "programmatic_tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpecificProgrammaticToolCallingParamType? ToEnum(string value)
        {
            return value switch
            {
                "programmatic_tool_calling" => BetaSpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling,
                _ => null,
            };
        }
    }
}