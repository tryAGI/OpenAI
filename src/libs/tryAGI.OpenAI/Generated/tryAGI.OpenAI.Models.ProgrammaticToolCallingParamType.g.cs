
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the tool. Always `programmatic_tool_calling`.<br/>
    /// Default Value: programmatic_tool_calling
    /// </summary>
    public enum ProgrammaticToolCallingParamType
    {
        /// <summary>
        ///
        /// </summary>
        ProgrammaticToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProgrammaticToolCallingParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProgrammaticToolCallingParamType value)
        {
            return value switch
            {
                ProgrammaticToolCallingParamType.ProgrammaticToolCalling => "programmatic_tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProgrammaticToolCallingParamType? ToEnum(string value)
        {
            return value switch
            {
                "programmatic_tool_calling" => ProgrammaticToolCallingParamType.ProgrammaticToolCalling,
                _ => null,
            };
        }
    }
}