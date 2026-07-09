
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The outcome type. Always `exit`.<br/>
    /// Default Value: exit
    /// </summary>
    public enum BetaFunctionShellCallOutputExitOutcomeType
    {
        /// <summary>
        /// 
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFunctionShellCallOutputExitOutcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallOutputExitOutcomeType value)
        {
            return value switch
            {
                BetaFunctionShellCallOutputExitOutcomeType.Exit => "exit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallOutputExitOutcomeType? ToEnum(string value)
        {
            return value switch
            {
                "exit" => BetaFunctionShellCallOutputExitOutcomeType.Exit,
                _ => null,
            };
        }
    }
}