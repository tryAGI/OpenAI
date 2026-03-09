
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `shell`.<br/>
    /// Default Value: shell
    /// </summary>
    public enum SpecificFunctionShellParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Shell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpecificFunctionShellParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpecificFunctionShellParamType value)
        {
            return value switch
            {
                SpecificFunctionShellParamType.Shell => "shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpecificFunctionShellParamType? ToEnum(string value)
        {
            return value switch
            {
                "shell" => SpecificFunctionShellParamType.Shell,
                _ => null,
            };
        }
    }
}