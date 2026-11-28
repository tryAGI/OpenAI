
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputImageType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputImageType value)
        {
            return value switch
            {
                RealtimeResponseInputImageType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputImageType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => RealtimeResponseInputImageType.InputImage,
                _ => null,
            };
        }
    }
}