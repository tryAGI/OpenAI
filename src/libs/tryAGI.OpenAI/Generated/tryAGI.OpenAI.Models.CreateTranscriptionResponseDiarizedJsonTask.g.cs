
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of task that was run. Always `transcribe`.
    /// </summary>
    public enum CreateTranscriptionResponseDiarizedJsonTask
    {
        /// <summary>
        /// 
        /// </summary>
        Transcribe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranscriptionResponseDiarizedJsonTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionResponseDiarizedJsonTask value)
        {
            return value switch
            {
                CreateTranscriptionResponseDiarizedJsonTask.Transcribe => "transcribe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionResponseDiarizedJsonTask? ToEnum(string value)
        {
            return value switch
            {
                "transcribe" => CreateTranscriptionResponseDiarizedJsonTask.Transcribe,
                _ => null,
            };
        }
    }
}