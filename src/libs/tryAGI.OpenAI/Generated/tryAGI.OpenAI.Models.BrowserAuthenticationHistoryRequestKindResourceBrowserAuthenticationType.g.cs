
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `browser_authentication`.<br/>
    /// Default Value: browser_authentication
    /// </summary>
    public enum BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType
    {
        /// <summary>
        ///
        /// </summary>
        BrowserAuthentication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType value)
        {
            return value switch
            {
                BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType.BrowserAuthentication => "browser_authentication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType? ToEnum(string value)
        {
            return value switch
            {
                "browser_authentication" => BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType.BrowserAuthentication,
                _ => null,
            };
        }
    }
}