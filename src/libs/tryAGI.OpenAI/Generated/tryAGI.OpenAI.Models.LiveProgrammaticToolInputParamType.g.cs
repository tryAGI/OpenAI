
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: programmatic_tool_calling
    /// </summary>
    public enum LiveProgrammaticToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        ProgrammaticToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveProgrammaticToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveProgrammaticToolInputParamType value)
        {
            return value switch
            {
                LiveProgrammaticToolInputParamType.ProgrammaticToolCalling => "programmatic_tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveProgrammaticToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "programmatic_tool_calling" => LiveProgrammaticToolInputParamType.ProgrammaticToolCalling,
                _ => null,
            };
        }
    }
}