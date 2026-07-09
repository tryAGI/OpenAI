
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The environment type. Always `local`.<br/>
    /// Default Value: local
    /// </summary>
    public enum BetaLocalEnvironmentResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLocalEnvironmentResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLocalEnvironmentResourceType value)
        {
            return value switch
            {
                BetaLocalEnvironmentResourceType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLocalEnvironmentResourceType? ToEnum(string value)
        {
            return value switch
            {
                "local" => BetaLocalEnvironmentResourceType.Local,
                _ => null,
            };
        }
    }
}