
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputMessageUserVariant2Role
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputMessageUserVariant2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputMessageUserVariant2Role value)
        {
            return value switch
            {
                RealtimeResponseInputMessageUserVariant2Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputMessageUserVariant2Role? ToEnum(string value)
        {
            return value switch
            {
                "user" => RealtimeResponseInputMessageUserVariant2Role.User,
                _ => null,
            };
        }
    }
}