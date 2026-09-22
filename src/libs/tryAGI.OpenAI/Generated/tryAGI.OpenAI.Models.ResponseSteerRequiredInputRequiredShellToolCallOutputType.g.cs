
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseSteerRequiredInputRequiredShellToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        ShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerRequiredInputRequiredShellToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerRequiredInputRequiredShellToolCallOutputType value)
        {
            return value switch
            {
                ResponseSteerRequiredInputRequiredShellToolCallOutputType.ShellCallOutput => "shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredShellToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call_output" => ResponseSteerRequiredInputRequiredShellToolCallOutputType.ShellCallOutput,
                _ => null,
            };
        }
    }
}