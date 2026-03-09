
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseModalitiesVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseModalitiesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseModalitiesVariant1Item value)
        {
            return value switch
            {
                ResponseModalitiesVariant1Item.Text => "text",
                ResponseModalitiesVariant1Item.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseModalitiesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponseModalitiesVariant1Item.Text,
                "audio" => ResponseModalitiesVariant1Item.Audio,
                _ => null,
            };
        }
    }
}