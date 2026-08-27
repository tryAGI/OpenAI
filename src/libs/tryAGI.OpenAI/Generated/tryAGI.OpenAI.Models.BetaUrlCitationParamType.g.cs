
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The citation type. Always `url_citation`.<br/>
    /// Default Value: url_citation
    /// </summary>
    public enum BetaUrlCitationParamType
    {
        /// <summary>
        ///
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUrlCitationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUrlCitationParamType value)
        {
            return value switch
            {
                BetaUrlCitationParamType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUrlCitationParamType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => BetaUrlCitationParamType.UrlCitation,
                _ => null,
            };
        }
    }
}