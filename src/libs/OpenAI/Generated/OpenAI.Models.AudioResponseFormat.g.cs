
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The format of the output, in one of these options: `json`, `text`, `srt`, `verbose_json`, or `vtt`.<br/>
    /// Default Value: json
    /// </summary>
    public enum AudioResponseFormat
    {
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        Json,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        Text,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        Srt,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        VerboseJson,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioResponseFormat value)
        {
            return value switch
            {
                AudioResponseFormat.Json => "json",
                AudioResponseFormat.Text => "text",
                AudioResponseFormat.Srt => "srt",
                AudioResponseFormat.VerboseJson => "verbose_json",
                AudioResponseFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => AudioResponseFormat.Json,
                "text" => AudioResponseFormat.Text,
                "srt" => AudioResponseFormat.Srt,
                "verbose_json" => AudioResponseFormat.VerboseJson,
                "vtt" => AudioResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}