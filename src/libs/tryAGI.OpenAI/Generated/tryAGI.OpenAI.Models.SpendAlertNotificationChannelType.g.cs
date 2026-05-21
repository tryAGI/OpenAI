
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The notification channel type. Currently only `email` is supported.
    /// </summary>
    public enum SpendAlertNotificationChannelType
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpendAlertNotificationChannelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendAlertNotificationChannelType value)
        {
            return value switch
            {
                SpendAlertNotificationChannelType.Email => "email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendAlertNotificationChannelType? ToEnum(string value)
        {
            return value switch
            {
                "email" => SpendAlertNotificationChannelType.Email,
                _ => null,
            };
        }
    }
}