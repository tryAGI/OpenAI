
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `url` for this annotation.<br/>
    /// Default Value: url
    /// </summary>
    public enum UrlAnnotationType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UrlAnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UrlAnnotationType value)
        {
            return value switch
            {
                UrlAnnotationType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UrlAnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "url" => UrlAnnotationType.Url,
                _ => null,
            };
        }
    }
}