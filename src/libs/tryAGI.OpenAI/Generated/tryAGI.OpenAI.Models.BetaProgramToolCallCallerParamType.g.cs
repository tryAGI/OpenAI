
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The caller type. Always `program`.<br/>
    /// Default Value: program
    /// </summary>
    public enum BetaProgramToolCallCallerParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Program,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaProgramToolCallCallerParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaProgramToolCallCallerParamType value)
        {
            return value switch
            {
                BetaProgramToolCallCallerParamType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaProgramToolCallCallerParamType? ToEnum(string value)
        {
            return value switch
            {
                "program" => BetaProgramToolCallCallerParamType.Program,
                _ => null,
            };
        }
    }
}