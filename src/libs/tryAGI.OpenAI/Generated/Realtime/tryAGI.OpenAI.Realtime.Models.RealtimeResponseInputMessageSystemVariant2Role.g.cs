
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputMessageSystemVariant2Role
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputMessageSystemVariant2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputMessageSystemVariant2Role value)
        {
            return value switch
            {
                RealtimeResponseInputMessageSystemVariant2Role.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputMessageSystemVariant2Role? ToEnum(string value)
        {
            return value switch
            {
                "system" => RealtimeResponseInputMessageSystemVariant2Role.System,
                _ => null,
            };
        }
    }
}