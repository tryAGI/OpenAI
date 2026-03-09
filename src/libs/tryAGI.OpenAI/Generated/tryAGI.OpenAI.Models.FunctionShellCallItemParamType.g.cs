
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `shell_call`.<br/>
    /// Default Value: shell_call
    /// </summary>
    public enum FunctionShellCallItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ShellCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellCallItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallItemParamType value)
        {
            return value switch
            {
                FunctionShellCallItemParamType.ShellCall => "shell_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call" => FunctionShellCallItemParamType.ShellCall,
                _ => null,
            };
        }
    }
}