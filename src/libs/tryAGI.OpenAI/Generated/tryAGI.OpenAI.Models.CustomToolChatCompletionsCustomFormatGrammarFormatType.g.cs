
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Grammar format. Always `grammar`.
    /// </summary>
    public enum CustomToolChatCompletionsCustomFormatGrammarFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolChatCompletionsCustomFormatGrammarFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolChatCompletionsCustomFormatGrammarFormatType value)
        {
            return value switch
            {
                CustomToolChatCompletionsCustomFormatGrammarFormatType.Grammar => "grammar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolChatCompletionsCustomFormatGrammarFormatType? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => CustomToolChatCompletionsCustomFormatGrammarFormatType.Grammar,
                _ => null,
            };
        }
    }
}