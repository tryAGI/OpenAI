
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModerationOutputDiscriminatorType
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
    public static class ModerationOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationOutputDiscriminatorType value)
        {
            return value switch
            {
                ModerationOutputDiscriminatorType.Error => "error",
                ModerationOutputDiscriminatorType.ModerationResult => "moderation_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ModerationOutputDiscriminatorType.Error,
                "moderation_result" => ModerationOutputDiscriminatorType.ModerationResult,
                _ => null,
            };
        }
    }
}