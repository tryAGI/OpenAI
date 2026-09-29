
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatCompletionMessageListDataItemContentPartsVariant1ItemType
    {
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
        /// <summary>
        ///
        /// </summary>
        InputAudio,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageListDataItemContentPartsVariant1ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageListDataItemContentPartsVariant1ItemType value)
        {
            return value switch
            {
                ChatCompletionMessageListDataItemContentPartsVariant1ItemType.File => "file",
                ChatCompletionMessageListDataItemContentPartsVariant1ItemType.ImageUrl => "image_url",
                ChatCompletionMessageListDataItemContentPartsVariant1ItemType.InputAudio => "input_audio",
                ChatCompletionMessageListDataItemContentPartsVariant1ItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageListDataItemContentPartsVariant1ItemType? ToEnum(string value)
        {
            return value switch
            {
                "file" => ChatCompletionMessageListDataItemContentPartsVariant1ItemType.File,
                "image_url" => ChatCompletionMessageListDataItemContentPartsVariant1ItemType.ImageUrl,
                "input_audio" => ChatCompletionMessageListDataItemContentPartsVariant1ItemType.InputAudio,
                "text" => ChatCompletionMessageListDataItemContentPartsVariant1ItemType.Text,
                _ => null,
            };
        }
    }
}