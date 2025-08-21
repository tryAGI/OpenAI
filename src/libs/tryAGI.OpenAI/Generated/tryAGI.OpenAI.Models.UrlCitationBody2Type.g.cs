
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the URL citation. Always `url_citation`.<br/>
    /// Default Value: url_citation
    /// </summary>
    public enum UrlCitationBody2Type
    {
        /// <summary>
        /// 
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UrlCitationBody2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UrlCitationBody2Type value)
        {
            return value switch
            {
                UrlCitationBody2Type.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UrlCitationBody2Type? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => UrlCitationBody2Type.UrlCitation,
                _ => null,
            };
        }
    }
}