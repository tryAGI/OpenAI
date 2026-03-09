
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Unconstrained text format. Always `text`.
    /// </summary>
    public enum CustomToolChatCompletionsCustomFormatTextFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolChatCompletionsCustomFormatTextFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolChatCompletionsCustomFormatTextFormatType value)
        {
            return value switch
            {
                CustomToolChatCompletionsCustomFormatTextFormatType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolChatCompletionsCustomFormatTextFormatType? ToEnum(string value)
        {
            return value switch
            {
                "text" => CustomToolChatCompletionsCustomFormatTextFormatType.Text,
                _ => null,
            };
        }
    }
}