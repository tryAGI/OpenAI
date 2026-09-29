
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        BrowserAuthentication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BrowserAuthenticationHistoryRequestKindResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType value)
        {
            return value switch
            {
                BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType.BrowserAuthentication => "browser_authentication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "browser_authentication" => BrowserAuthenticationHistoryRequestKindResourceDiscriminatorType.BrowserAuthentication,
                _ => null,
            };
        }
    }
}