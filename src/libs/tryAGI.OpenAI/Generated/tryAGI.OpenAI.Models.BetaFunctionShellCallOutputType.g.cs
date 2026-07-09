
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the shell call output. Always `shell_call_output`.<br/>
    /// Default Value: shell_call_output
    /// </summary>
    public enum BetaFunctionShellCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        ShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFunctionShellCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallOutputType value)
        {
            return value switch
            {
                BetaFunctionShellCallOutputType.ShellCallOutput => "shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call_output" => BetaFunctionShellCallOutputType.ShellCallOutput,
                _ => null,
            };
        }
    }
}