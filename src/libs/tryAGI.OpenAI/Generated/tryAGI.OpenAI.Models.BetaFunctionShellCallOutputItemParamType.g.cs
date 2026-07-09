
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `shell_call_output`.<br/>
    /// Default Value: shell_call_output
    /// </summary>
    public enum BetaFunctionShellCallOutputItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFunctionShellCallOutputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallOutputItemParamType value)
        {
            return value switch
            {
                BetaFunctionShellCallOutputItemParamType.ShellCallOutput => "shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallOutputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call_output" => BetaFunctionShellCallOutputItemParamType.ShellCallOutput,
                _ => null,
            };
        }
    }
}