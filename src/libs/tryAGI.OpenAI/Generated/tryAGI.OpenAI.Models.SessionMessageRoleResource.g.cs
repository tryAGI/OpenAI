
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The author of a session message.
    /// </summary>
    public enum SessionMessageRoleResource
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionMessageRoleResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionMessageRoleResource value)
        {
            return value switch
            {
                SessionMessageRoleResource.Assistant => "assistant",
                SessionMessageRoleResource.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionMessageRoleResource? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => SessionMessageRoleResource.Assistant,
                "user" => SessionMessageRoleResource.User,
                _ => null,
            };
        }
    }
}