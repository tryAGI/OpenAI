
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The outcome type. Always `exit`.<br/>
    /// Default Value: exit
    /// </summary>
    public enum FunctionShellCallOutputExitOutcomeType
    {
        /// <summary>
        /// 
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellCallOutputExitOutcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallOutputExitOutcomeType value)
        {
            return value switch
            {
                FunctionShellCallOutputExitOutcomeType.Exit => "exit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallOutputExitOutcomeType? ToEnum(string value)
        {
            return value switch
            {
                "exit" => FunctionShellCallOutputExitOutcomeType.Exit,
                _ => null,
            };
        }
    }
}