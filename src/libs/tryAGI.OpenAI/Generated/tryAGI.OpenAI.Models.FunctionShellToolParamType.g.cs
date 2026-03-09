
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the shell tool. Always `shell`.<br/>
    /// Default Value: shell
    /// </summary>
    public enum FunctionShellToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Shell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellToolParamType value)
        {
            return value switch
            {
                FunctionShellToolParamType.Shell => "shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "shell" => FunctionShellToolParamType.Shell,
                _ => null,
            };
        }
    }
}