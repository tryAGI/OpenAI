
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputMessageAssistantVariant2Role
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputMessageAssistantVariant2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputMessageAssistantVariant2Role value)
        {
            return value switch
            {
                RealtimeResponseInputMessageAssistantVariant2Role.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputMessageAssistantVariant2Role? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => RealtimeResponseInputMessageAssistantVariant2Role.Assistant,
                _ => null,
            };
        }
    }
}