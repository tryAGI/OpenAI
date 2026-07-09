
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the local shell tool call output. Always `local_shell_call_output`.
    /// </summary>
    public enum BetaLocalShellToolCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        LocalShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLocalShellToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLocalShellToolCallOutputType value)
        {
            return value switch
            {
                BetaLocalShellToolCallOutputType.LocalShellCallOutput => "local_shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLocalShellToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "local_shell_call_output" => BetaLocalShellToolCallOutputType.LocalShellCallOutput,
                _ => null,
            };
        }
    }
}