
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.created`.
    /// </summary>
    public enum RealtimeTranslationServerEventSessionCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationServerEventSessionCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationServerEventSessionCreatedType value)
        {
            return value switch
            {
                RealtimeTranslationServerEventSessionCreatedType.SessionCreated => "session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationServerEventSessionCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.created" => RealtimeTranslationServerEventSessionCreatedType.SessionCreated,
                _ => null,
            };
        }
    }
}