
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFunctionShellCallOutputContentOutcomeDiscriminatorType
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
    public static class BetaFunctionShellCallOutputContentOutcomeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallOutputContentOutcomeDiscriminatorType value)
        {
            return value switch
            {
                BetaFunctionShellCallOutputContentOutcomeDiscriminatorType.Exit => "exit",
                BetaFunctionShellCallOutputContentOutcomeDiscriminatorType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallOutputContentOutcomeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exit" => BetaFunctionShellCallOutputContentOutcomeDiscriminatorType.Exit,
                "timeout" => BetaFunctionShellCallOutputContentOutcomeDiscriminatorType.Timeout,
                _ => null,
            };
        }
    }
}