
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: email
    /// </summary>
    public enum EmailNotificationChannelType
    {
        /// <summary>
        ///
        /// </summary>
        Email,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailNotificationChannelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailNotificationChannelType value)
        {
            return value switch
            {
                EmailNotificationChannelType.Email => "email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailNotificationChannelType? ToEnum(string value)
        {
            return value switch
            {
                "email" => EmailNotificationChannelType.Email,
                _ => null,
            };
        }
    }
}