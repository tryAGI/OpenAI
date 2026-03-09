
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionModalitiesVariant1Item
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
    public static class ChatCompletionModalitiesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionModalitiesVariant1Item value)
        {
            return value switch
            {
                ChatCompletionModalitiesVariant1Item.Text => "text",
                ChatCompletionModalitiesVariant1Item.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionModalitiesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionModalitiesVariant1Item.Text,
                "audio" => ChatCompletionModalitiesVariant1Item.Audio,
                _ => null,
            };
        }
    }
}