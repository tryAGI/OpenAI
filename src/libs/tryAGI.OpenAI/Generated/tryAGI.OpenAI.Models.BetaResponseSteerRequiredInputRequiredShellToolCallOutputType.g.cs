
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerRequiredInputRequiredShellToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        ShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerRequiredInputRequiredShellToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerRequiredInputRequiredShellToolCallOutputType value)
        {
            return value switch
            {
                BetaResponseSteerRequiredInputRequiredShellToolCallOutputType.ShellCallOutput => "shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerRequiredInputRequiredShellToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call_output" => BetaResponseSteerRequiredInputRequiredShellToolCallOutputType.ShellCallOutput,
                _ => null,
            };
        }
    }
}