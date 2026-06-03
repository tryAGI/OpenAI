
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModerationInputDiscriminatorType
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
    public static class ModerationInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationInputDiscriminatorType value)
        {
            return value switch
            {
                ModerationInputDiscriminatorType.Error => "error",
                ModerationInputDiscriminatorType.ModerationResult => "moderation_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ModerationInputDiscriminatorType.Error,
                "moderation_result" => ModerationInputDiscriminatorType.ModerationResult,
                _ => null,
            };
        }
    }
}