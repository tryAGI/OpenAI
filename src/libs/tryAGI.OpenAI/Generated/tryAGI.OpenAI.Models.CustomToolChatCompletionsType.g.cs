
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the custom tool. Always `custom`.
    /// </summary>
    public enum CustomToolChatCompletionsType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolChatCompletionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolChatCompletionsType value)
        {
            return value switch
            {
                CustomToolChatCompletionsType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolChatCompletionsType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CustomToolChatCompletionsType.Custom,
                _ => null,
            };
        }
    }
}