
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format of the output, in one of these options: `json`, `text`, `srt`, `verbose_json`, `vtt`, or `diarized_json`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`. For `gpt-4o-transcribe-diarize`, the supported formats are `json`, `text`, and `diarized_json`, with `diarized_json` required to receive speaker annotations.<br/>
    /// Default Value: json
    /// </summary>
    public enum AudioResponseFormat
    {
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, `vtt`, or `diarized_json`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`. For `gpt-4o-transcribe-diarize`, the supported formats are `json`, `text`, and `diarized_json`, with `diarized_json` required to receive speaker annotations.
        /// </summary>
        DiarizedJson,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, `vtt`, or `diarized_json`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`. For `gpt-4o-transcribe-diarize`, the supported formats are `json`, `text`, and `diarized_json`, with `diarized_json` required to receive speaker annotations.
        /// </summary>
        Json,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, `vtt`, or `diarized_json`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`. For `gpt-4o-transcribe-diarize`, the supported formats are `json`, `text`, and `diarized_json`, with `diarized_json` required to receive speaker annotations.
        /// </summary>
        Srt,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, `vtt`, or `diarized_json`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`. For `gpt-4o-transcribe-diarize`, the supported formats are `json`, `text`, and `diarized_json`, with `diarized_json` required to receive speaker annotations.
        /// </summary>
        Text,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, `vtt`, or `diarized_json`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`. For `gpt-4o-transcribe-diarize`, the supported formats are `json`, `text`, and `diarized_json`, with `diarized_json` required to receive speaker annotations.
        /// </summary>
        VerboseJson,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, `vtt`, or `diarized_json`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`. For `gpt-4o-transcribe-diarize`, the supported formats are `json`, `text`, and `diarized_json`, with `diarized_json` required to receive speaker annotations.
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
                AudioResponseFormat.DiarizedJson => "diarized_json",
                AudioResponseFormat.Json => "json",
                AudioResponseFormat.Srt => "srt",
                AudioResponseFormat.Text => "text",
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
                "diarized_json" => AudioResponseFormat.DiarizedJson,
                "json" => AudioResponseFormat.Json,
                "srt" => AudioResponseFormat.Srt,
                "text" => AudioResponseFormat.Text,
                "verbose_json" => AudioResponseFormat.VerboseJson,
                "vtt" => AudioResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}