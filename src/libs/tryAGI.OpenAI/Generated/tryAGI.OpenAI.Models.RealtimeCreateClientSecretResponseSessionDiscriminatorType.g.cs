
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeCreateClientSecretResponseSessionDiscriminatorType
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
    public static class RealtimeCreateClientSecretResponseSessionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeCreateClientSecretResponseSessionDiscriminatorType value)
        {
            return value switch
            {
                RealtimeCreateClientSecretResponseSessionDiscriminatorType.Realtime => "realtime",
                RealtimeCreateClientSecretResponseSessionDiscriminatorType.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeCreateClientSecretResponseSessionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "realtime" => RealtimeCreateClientSecretResponseSessionDiscriminatorType.Realtime,
                "transcription" => RealtimeCreateClientSecretResponseSessionDiscriminatorType.Transcription,
                _ => null,
            };
        }
    }
}