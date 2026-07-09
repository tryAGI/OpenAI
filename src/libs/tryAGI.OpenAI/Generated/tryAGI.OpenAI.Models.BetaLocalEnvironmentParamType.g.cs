
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use a local computer environment.<br/>
    /// Default Value: local
    /// </summary>
    public enum BetaLocalEnvironmentParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLocalEnvironmentParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLocalEnvironmentParamType value)
        {
            return value switch
            {
                BetaLocalEnvironmentParamType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLocalEnvironmentParamType? ToEnum(string value)
        {
            return value switch
            {
                "local" => BetaLocalEnvironmentParamType.Local,
                _ => null,
            };
        }
    }
}