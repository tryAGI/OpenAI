
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The environment type. Always `local`.<br/>
    /// Default Value: local
    /// </summary>
    public enum LocalEnvironmentResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalEnvironmentResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalEnvironmentResourceType value)
        {
            return value switch
            {
                LocalEnvironmentResourceType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalEnvironmentResourceType? ToEnum(string value)
        {
            return value switch
            {
                "local" => LocalEnvironmentResourceType.Local,
                _ => null,
            };
        }
    }
}