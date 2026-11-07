
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Selects the session type. Set `transcription` and omit `model` for a transcription session. If omitted, the session type from a client secret applies when present; otherwise the intent is `realtime`.
    /// </summary>
    public enum RealtimeConnectDocumentationParamsIntent
    {
        /// <summary>
        ///
        /// </summary>
        Realtime,
        /// <summary>
        ///
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConnectDocumentationParamsIntentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConnectDocumentationParamsIntent value)
        {
            return value switch
            {
                RealtimeConnectDocumentationParamsIntent.Realtime => "realtime",
                RealtimeConnectDocumentationParamsIntent.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConnectDocumentationParamsIntent? ToEnum(string value)
        {
            return value switch
            {
                "realtime" => RealtimeConnectDocumentationParamsIntent.Realtime,
                "transcription" => RealtimeConnectDocumentationParamsIntent.Transcription,
                _ => null,
            };
        }
    }
}