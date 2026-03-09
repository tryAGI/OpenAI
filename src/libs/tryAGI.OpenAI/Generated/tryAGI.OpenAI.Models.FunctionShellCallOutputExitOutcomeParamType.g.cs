
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The outcome type. Always `exit`.<br/>
    /// Default Value: exit
    /// </summary>
    public enum FunctionShellCallOutputExitOutcomeParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellCallOutputExitOutcomeParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallOutputExitOutcomeParamType value)
        {
            return value switch
            {
                FunctionShellCallOutputExitOutcomeParamType.Exit => "exit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallOutputExitOutcomeParamType? ToEnum(string value)
        {
            return value switch
            {
                "exit" => FunctionShellCallOutputExitOutcomeParamType.Exit,
                _ => null,
            };
        }
    }
}