
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: email
    /// </summary>
    public enum SpendLimitEmailNotificationChannelParamsType
    {
        /// <summary>
        ///
        /// </summary>
        Email,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpendLimitEmailNotificationChannelParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendLimitEmailNotificationChannelParamsType value)
        {
            return value switch
            {
                SpendLimitEmailNotificationChannelParamsType.Email => "email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendLimitEmailNotificationChannelParamsType? ToEnum(string value)
        {
            return value switch
            {
                "email" => SpendLimitEmailNotificationChannelParamsType.Email,
                _ => null,
            };
        }
    }
}