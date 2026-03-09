
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `shell_call_output`.<br/>
    /// Default Value: shell_call_output
    /// </summary>
    public enum FunctionShellCallOutputItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellCallOutputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallOutputItemParamType value)
        {
            return value switch
            {
                FunctionShellCallOutputItemParamType.ShellCallOutput => "shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallOutputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call_output" => FunctionShellCallOutputItemParamType.ShellCallOutput,
                _ => null,
            };
        }
    }
}