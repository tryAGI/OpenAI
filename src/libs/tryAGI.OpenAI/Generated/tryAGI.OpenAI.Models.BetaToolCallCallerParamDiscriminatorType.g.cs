
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolCallCallerParamDiscriminatorType
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
    public static class BetaToolCallCallerParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolCallCallerParamDiscriminatorType value)
        {
            return value switch
            {
                BetaToolCallCallerParamDiscriminatorType.Direct => "direct",
                BetaToolCallCallerParamDiscriminatorType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolCallCallerParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaToolCallCallerParamDiscriminatorType.Direct,
                "program" => BetaToolCallCallerParamDiscriminatorType.Program,
                _ => null,
            };
        }
    }
}