
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The session type. Always `translation` for Realtime translation sessions.
    /// </summary>
    public enum RealtimeTranslationSessionType
    {
        /// <summary>
        /// 
        /// </summary>
        Translation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationSessionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationSessionType value)
        {
            return value switch
            {
                RealtimeTranslationSessionType.Translation => "translation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationSessionType? ToEnum(string value)
        {
            return value switch
            {
                "translation" => RealtimeTranslationSessionType.Translation,
                _ => null,
            };
        }
    }
}