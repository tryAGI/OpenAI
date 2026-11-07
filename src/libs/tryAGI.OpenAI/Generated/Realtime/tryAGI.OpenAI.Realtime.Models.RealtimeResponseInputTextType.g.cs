
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputTextType
    {
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputTextType value)
        {
            return value switch
            {
                RealtimeResponseInputTextType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputTextType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => RealtimeResponseInputTextType.InputText,
                _ => null,
            };
        }
    }
}