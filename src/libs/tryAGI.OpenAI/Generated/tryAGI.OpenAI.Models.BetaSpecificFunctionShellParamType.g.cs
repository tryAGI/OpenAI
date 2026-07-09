
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `shell`.<br/>
    /// Default Value: shell
    /// </summary>
    public enum BetaSpecificFunctionShellParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Shell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSpecificFunctionShellParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpecificFunctionShellParamType value)
        {
            return value switch
            {
                BetaSpecificFunctionShellParamType.Shell => "shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpecificFunctionShellParamType? ToEnum(string value)
        {
            return value switch
            {
                "shell" => BetaSpecificFunctionShellParamType.Shell,
                _ => null,
            };
        }
    }
}