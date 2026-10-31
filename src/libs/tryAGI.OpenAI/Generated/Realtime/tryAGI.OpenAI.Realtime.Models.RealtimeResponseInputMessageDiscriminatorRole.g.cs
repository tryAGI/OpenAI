
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputMessageDiscriminatorRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputMessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputMessageDiscriminatorRole value)
        {
            return value switch
            {
                RealtimeResponseInputMessageDiscriminatorRole.Assistant => "assistant",
                RealtimeResponseInputMessageDiscriminatorRole.Developer => "developer",
                RealtimeResponseInputMessageDiscriminatorRole.System => "system",
                RealtimeResponseInputMessageDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputMessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => RealtimeResponseInputMessageDiscriminatorRole.Assistant,
                "developer" => RealtimeResponseInputMessageDiscriminatorRole.Developer,
                "system" => RealtimeResponseInputMessageDiscriminatorRole.System,
                "user" => RealtimeResponseInputMessageDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}