
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the shell call output. Always `shell_call_output`.<br/>
    /// Default Value: shell_call_output
    /// </summary>
    public enum FunctionShellCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        ShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallOutputType value)
        {
            return value switch
            {
                FunctionShellCallOutputType.ShellCallOutput => "shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call_output" => FunctionShellCallOutputType.ShellCallOutput,
                _ => null,
            };
        }
    }
}