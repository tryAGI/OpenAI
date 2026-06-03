
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which was always `moderation_result` for successful moderation results.<br/>
    /// Default Value: moderation_result
    /// </summary>
    public enum ModerationResultBodyType
    {
        /// <summary>
        /// 
        /// </summary>
        ModerationResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationResultBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationResultBodyType value)
        {
            return value switch
            {
                ModerationResultBodyType.ModerationResult => "moderation_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationResultBodyType? ToEnum(string value)
        {
            return value switch
            {
                "moderation_result" => ModerationResultBodyType.ModerationResult,
                _ => null,
            };
        }
    }
}