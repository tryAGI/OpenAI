
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Controls how long the model waits before emitting transcription text.<br/>
    /// Higher values can improve transcription accuracy at the cost of latency.<br/>
    /// Only supported with `gpt-realtime-whisper` in GA Realtime sessions.
    /// </summary>
    public enum AudioTranscriptionDelay
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTranscriptionDelayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranscriptionDelay value)
        {
            return value switch
            {
                AudioTranscriptionDelay.High => "high",
                AudioTranscriptionDelay.Low => "low",
                AudioTranscriptionDelay.Medium => "medium",
                AudioTranscriptionDelay.Minimal => "minimal",
                AudioTranscriptionDelay.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranscriptionDelay? ToEnum(string value)
        {
            return value switch
            {
                "high" => AudioTranscriptionDelay.High,
                "low" => AudioTranscriptionDelay.Low,
                "medium" => AudioTranscriptionDelay.Medium,
                "minimal" => AudioTranscriptionDelay.Minimal,
                "xhigh" => AudioTranscriptionDelay.Xhigh,
                _ => null,
            };
        }
    }
}