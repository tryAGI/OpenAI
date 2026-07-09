
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaModerationInputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        ModerationResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaModerationInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaModerationInputDiscriminatorType value)
        {
            return value switch
            {
                BetaModerationInputDiscriminatorType.Error => "error",
                BetaModerationInputDiscriminatorType.ModerationResult => "moderation_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaModerationInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => BetaModerationInputDiscriminatorType.Error,
                "moderation_result" => BetaModerationInputDiscriminatorType.ModerationResult,
                _ => null,
            };
        }
    }
}