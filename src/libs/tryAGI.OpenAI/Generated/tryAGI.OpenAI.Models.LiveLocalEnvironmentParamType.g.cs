
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use a local computer environment.<br/>
    /// Default Value: local
    /// </summary>
    public enum LiveLocalEnvironmentParamType
    {
        /// <summary>
        ///
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveLocalEnvironmentParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveLocalEnvironmentParamType value)
        {
            return value switch
            {
                LiveLocalEnvironmentParamType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveLocalEnvironmentParamType? ToEnum(string value)
        {
            return value switch
            {
                "local" => LiveLocalEnvironmentParamType.Local,
                _ => null,
            };
        }
    }
}