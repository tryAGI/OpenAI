
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `shell_call`.<br/>
    /// Default Value: shell_call
    /// </summary>
    public enum BetaFunctionShellCallType
    {
        /// <summary>
        /// 
        /// </summary>
        ShellCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFunctionShellCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallType value)
        {
            return value switch
            {
                BetaFunctionShellCallType.ShellCall => "shell_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call" => BetaFunctionShellCallType.ShellCall,
                _ => null,
            };
        }
    }
}