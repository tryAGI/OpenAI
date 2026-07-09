
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the shell tool. Always `shell`.<br/>
    /// Default Value: shell
    /// </summary>
    public enum BetaFunctionShellToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Shell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFunctionShellToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellToolParamType value)
        {
            return value switch
            {
                BetaFunctionShellToolParamType.Shell => "shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "shell" => BetaFunctionShellToolParamType.Shell,
                _ => null,
            };
        }
    }
}