
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `url`.<br/>
    /// Default Value: url
    /// </summary>
    public enum UrlAnnotationSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UrlAnnotationSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UrlAnnotationSourceType value)
        {
            return value switch
            {
                UrlAnnotationSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UrlAnnotationSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => UrlAnnotationSourceType.Url,
                _ => null,
            };
        }
    }
}