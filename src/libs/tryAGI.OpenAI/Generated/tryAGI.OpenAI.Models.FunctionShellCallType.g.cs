
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `shell_call`.<br/>
    /// Default Value: shell_call
    /// </summary>
    public enum FunctionShellCallType
    {
        /// <summary>
        /// 
        /// </summary>
        ShellCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallType value)
        {
            return value switch
            {
                FunctionShellCallType.ShellCall => "shell_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call" => FunctionShellCallType.ShellCall,
                _ => null,
            };
        }
    }
}