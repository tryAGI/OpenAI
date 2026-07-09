
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaModerationOutputDiscriminatorType
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
    public static class BetaModerationOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaModerationOutputDiscriminatorType value)
        {
            return value switch
            {
                BetaModerationOutputDiscriminatorType.Error => "error",
                BetaModerationOutputDiscriminatorType.ModerationResult => "moderation_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaModerationOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => BetaModerationOutputDiscriminatorType.Error,
                "moderation_result" => BetaModerationOutputDiscriminatorType.ModerationResult,
                _ => null,
            };
        }
    }
}