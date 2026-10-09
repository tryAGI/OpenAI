
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `shell`.<br/>
    /// Default Value: shell
    /// </summary>
    public enum LiveSpecificFunctionShellParamType
    {
        /// <summary>
        ///
        /// </summary>
        Shell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpecificFunctionShellParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpecificFunctionShellParamType value)
        {
            return value switch
            {
                LiveSpecificFunctionShellParamType.Shell => "shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpecificFunctionShellParamType? ToEnum(string value)
        {
            return value switch
            {
                "shell" => LiveSpecificFunctionShellParamType.Shell,
                _ => null,
            };
        }
    }
}