
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Unconstrained text format. Always `text`.
    /// </summary>
    public enum CustomToolChatCompletionsCustomFormatVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolChatCompletionsCustomFormatVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolChatCompletionsCustomFormatVariant1Type value)
        {
            return value switch
            {
                CustomToolChatCompletionsCustomFormatVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolChatCompletionsCustomFormatVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => CustomToolChatCompletionsCustomFormatVariant1Type.Text,
                _ => null,
            };
        }
    }
}