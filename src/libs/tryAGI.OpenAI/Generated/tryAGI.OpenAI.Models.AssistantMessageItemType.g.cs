
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.assistant_message`.<br/>
    /// Default Value: chatkit.assistant_message
    /// </summary>
    public enum AssistantMessageItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitAssistantMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantMessageItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageItemType value)
        {
            return value switch
            {
                AssistantMessageItemType.ChatkitAssistantMessage => "chatkit.assistant_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageItemType? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.assistant_message" => AssistantMessageItemType.ChatkitAssistantMessage,
                _ => null,
            };
        }
    }
}