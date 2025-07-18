
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the local shell tool call output. Always `local_shell_call_output`.
    /// </summary>
    public enum LocalShellToolCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        LocalShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalShellToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellToolCallOutputType value)
        {
            return value switch
            {
                LocalShellToolCallOutputType.LocalShellCallOutput => "local_shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "local_shell_call_output" => LocalShellToolCallOutputType.LocalShellCallOutput,
                _ => null,
            };
        }
    }
}