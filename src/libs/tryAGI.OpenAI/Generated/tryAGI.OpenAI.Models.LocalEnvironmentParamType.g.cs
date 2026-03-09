
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use a local computer environment.<br/>
    /// Default Value: local
    /// </summary>
    public enum LocalEnvironmentParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalEnvironmentParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalEnvironmentParamType value)
        {
            return value switch
            {
                LocalEnvironmentParamType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalEnvironmentParamType? ToEnum(string value)
        {
            return value switch
            {
                "local" => LocalEnvironmentParamType.Local,
                _ => null,
            };
        }
    }
}