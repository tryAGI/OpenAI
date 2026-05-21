
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionShellCallOutputOutcomeParamDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Exit,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellCallOutputOutcomeParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallOutputOutcomeParamDiscriminatorType value)
        {
            return value switch
            {
                FunctionShellCallOutputOutcomeParamDiscriminatorType.Exit => "exit",
                FunctionShellCallOutputOutcomeParamDiscriminatorType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallOutputOutcomeParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exit" => FunctionShellCallOutputOutcomeParamDiscriminatorType.Exit,
                "timeout" => FunctionShellCallOutputOutcomeParamDiscriminatorType.Timeout,
                _ => null,
            };
        }
    }
}