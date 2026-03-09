
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.thread_item`.<br/>
    /// Default Value: chatkit.thread_item
    /// </summary>
    public enum AssistantMessageItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitThreadItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantMessageItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageItemObject value)
        {
            return value switch
            {
                AssistantMessageItemObject.ChatkitThreadItem => "chatkit.thread_item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageItemObject? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.thread_item" => AssistantMessageItemObject.ChatkitThreadItem,
                _ => null,
            };
        }
    }
}