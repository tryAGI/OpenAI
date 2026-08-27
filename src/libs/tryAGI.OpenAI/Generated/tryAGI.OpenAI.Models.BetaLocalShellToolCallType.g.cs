
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the local shell call. Always `local_shell_call`.
    /// </summary>
    public enum BetaLocalShellToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        LocalShellCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLocalShellToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLocalShellToolCallType value)
        {
            return value switch
            {
                BetaLocalShellToolCallType.LocalShellCall => "local_shell_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLocalShellToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "local_shell_call" => BetaLocalShellToolCallType.LocalShellCall,
                _ => null,
            };
        }
    }
}