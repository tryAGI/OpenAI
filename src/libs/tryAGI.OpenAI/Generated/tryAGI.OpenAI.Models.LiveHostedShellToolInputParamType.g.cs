
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: shell
    /// </summary>
    public enum LiveHostedShellToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        Shell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveHostedShellToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveHostedShellToolInputParamType value)
        {
            return value switch
            {
                LiveHostedShellToolInputParamType.Shell => "shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveHostedShellToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "shell" => LiveHostedShellToolInputParamType.Shell,
                _ => null,
            };
        }
    }
}