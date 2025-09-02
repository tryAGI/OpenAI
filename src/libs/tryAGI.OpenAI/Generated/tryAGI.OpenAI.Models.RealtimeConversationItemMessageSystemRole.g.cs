
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The role of the message sender. Always `system`.
    /// </summary>
    public enum RealtimeConversationItemMessageSystemRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageSystemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageSystemRole value)
        {
            return value switch
            {
                RealtimeConversationItemMessageSystemRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageSystemRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => RealtimeConversationItemMessageSystemRole.System,
                _ => null,
            };
        }
    }
}