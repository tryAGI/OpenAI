
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always list.<br/>
    /// Default Value: list
    /// </summary>
    public enum WebhookEndpointListResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEndpointListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEndpointListResourceObject value)
        {
            return value switch
            {
                WebhookEndpointListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEndpointListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => WebhookEndpointListResourceObject.List,
                _ => null,
            };
        }
    }
}