
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which was always `error` for moderation failures.<br/>
    /// Default Value: error
    /// </summary>
    public enum BetaModerationErrorBodyType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaModerationErrorBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaModerationErrorBodyType value)
        {
            return value switch
            {
                BetaModerationErrorBodyType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaModerationErrorBodyType? ToEnum(string value)
        {
            return value switch
            {
                "error" => BetaModerationErrorBodyType.Error,
                _ => null,
            };
        }
    }
}