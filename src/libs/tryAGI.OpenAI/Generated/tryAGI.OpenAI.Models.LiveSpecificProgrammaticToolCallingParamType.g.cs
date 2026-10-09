
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `programmatic_tool_calling`.<br/>
    /// Default Value: programmatic_tool_calling
    /// </summary>
    public enum LiveSpecificProgrammaticToolCallingParamType
    {
        /// <summary>
        ///
        /// </summary>
        ProgrammaticToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpecificProgrammaticToolCallingParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpecificProgrammaticToolCallingParamType value)
        {
            return value switch
            {
                LiveSpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling => "programmatic_tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpecificProgrammaticToolCallingParamType? ToEnum(string value)
        {
            return value switch
            {
                "programmatic_tool_calling" => LiveSpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling,
                _ => null,
            };
        }
    }
}