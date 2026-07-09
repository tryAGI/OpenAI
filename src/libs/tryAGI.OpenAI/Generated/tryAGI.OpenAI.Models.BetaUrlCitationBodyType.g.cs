
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the URL citation. Always `url_citation`.<br/>
    /// Default Value: url_citation
    /// </summary>
    public enum BetaUrlCitationBodyType
    {
        /// <summary>
        /// 
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUrlCitationBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUrlCitationBodyType value)
        {
            return value switch
            {
                BetaUrlCitationBodyType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUrlCitationBodyType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => BetaUrlCitationBodyType.UrlCitation,
                _ => null,
            };
        }
    }
}