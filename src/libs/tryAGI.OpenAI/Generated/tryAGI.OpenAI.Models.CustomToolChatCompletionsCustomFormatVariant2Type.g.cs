
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Grammar format. Always `grammar`.
    /// </summary>
    public enum CustomToolChatCompletionsCustomFormatVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolChatCompletionsCustomFormatVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolChatCompletionsCustomFormatVariant2Type value)
        {
            return value switch
            {
                CustomToolChatCompletionsCustomFormatVariant2Type.Grammar => "grammar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolChatCompletionsCustomFormatVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => CustomToolChatCompletionsCustomFormatVariant2Type.Grammar,
                _ => null,
            };
        }
    }
}