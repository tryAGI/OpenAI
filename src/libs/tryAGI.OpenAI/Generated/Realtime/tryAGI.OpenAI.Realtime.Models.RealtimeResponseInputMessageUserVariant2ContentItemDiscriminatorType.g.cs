
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudio,
        /// <summary>
        ///
        /// </summary>
        InputImage,
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType value)
        {
            return value switch
            {
                RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType.InputAudio => "input_audio",
                RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType.InputImage => "input_image",
                RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType.InputAudio,
                "input_image" => RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType.InputImage,
                "input_text" => RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}