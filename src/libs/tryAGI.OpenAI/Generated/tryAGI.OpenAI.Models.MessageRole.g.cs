
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Critic,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Discriminator,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageRole value)
        {
            return value switch
            {
                MessageRole.Assistant => "assistant",
                MessageRole.Critic => "critic",
                MessageRole.Developer => "developer",
                MessageRole.Discriminator => "discriminator",
                MessageRole.System => "system",
                MessageRole.Tool => "tool",
                MessageRole.Unknown => "unknown",
                MessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageRole.Assistant,
                "critic" => MessageRole.Critic,
                "developer" => MessageRole.Developer,
                "discriminator" => MessageRole.Discriminator,
                "system" => MessageRole.System,
                "tool" => MessageRole.Tool,
                "unknown" => MessageRole.Unknown,
                "user" => MessageRole.User,
                _ => null,
            };
        }
    }
}