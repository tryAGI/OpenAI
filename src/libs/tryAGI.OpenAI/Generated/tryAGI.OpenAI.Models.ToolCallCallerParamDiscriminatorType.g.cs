
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolCallCallerParamDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Program,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallCallerParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallCallerParamDiscriminatorType value)
        {
            return value switch
            {
                ToolCallCallerParamDiscriminatorType.Direct => "direct",
                ToolCallCallerParamDiscriminatorType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallCallerParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "direct" => ToolCallCallerParamDiscriminatorType.Direct,
                "program" => ToolCallCallerParamDiscriminatorType.Program,
                _ => null,
            };
        }
    }
}