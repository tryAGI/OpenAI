
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.incomplete`.
    /// </summary>
    public enum WebhookResponseIncompleteType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseIncomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookResponseIncompleteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookResponseIncompleteType value)
        {
            return value switch
            {
                WebhookResponseIncompleteType.ResponseIncomplete => "response.incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookResponseIncompleteType? ToEnum(string value)
        {
            return value switch
            {
                "response.incomplete" => WebhookResponseIncompleteType.ResponseIncomplete,
                _ => null,
            };
        }
    }
}