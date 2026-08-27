
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFunctionShellCallOutputOutcomeParamDiscriminatorType
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
    public static class BetaFunctionShellCallOutputOutcomeParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallOutputOutcomeParamDiscriminatorType value)
        {
            return value switch
            {
                BetaFunctionShellCallOutputOutcomeParamDiscriminatorType.Exit => "exit",
                BetaFunctionShellCallOutputOutcomeParamDiscriminatorType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallOutputOutcomeParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exit" => BetaFunctionShellCallOutputOutcomeParamDiscriminatorType.Exit,
                "timeout" => BetaFunctionShellCallOutputOutcomeParamDiscriminatorType.Timeout,
                _ => null,
            };
        }
    }
}