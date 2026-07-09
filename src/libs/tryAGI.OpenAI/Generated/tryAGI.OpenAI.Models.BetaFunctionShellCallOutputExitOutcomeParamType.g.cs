
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The outcome type. Always `exit`.<br/>
    /// Default Value: exit
    /// </summary>
    public enum BetaFunctionShellCallOutputExitOutcomeParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFunctionShellCallOutputExitOutcomeParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallOutputExitOutcomeParamType value)
        {
            return value switch
            {
                BetaFunctionShellCallOutputExitOutcomeParamType.Exit => "exit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallOutputExitOutcomeParamType? ToEnum(string value)
        {
            return value switch
            {
                "exit" => BetaFunctionShellCallOutputExitOutcomeParamType.Exit,
                _ => null,
            };
        }
    }
}