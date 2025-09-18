
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
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Critic,
        /// <summary>
        /// 
        /// </summary>
        Discriminator,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Tool,
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
                MessageRole.Unknown => "unknown",
                MessageRole.User => "user",
                MessageRole.Assistant => "assistant",
                MessageRole.System => "system",
                MessageRole.Critic => "critic",
                MessageRole.Discriminator => "discriminator",
                MessageRole.Developer => "developer",
                MessageRole.Tool => "tool",
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
                "unknown" => MessageRole.Unknown,
                "user" => MessageRole.User,
                "assistant" => MessageRole.Assistant,
                "system" => MessageRole.System,
                "critic" => MessageRole.Critic,
                "discriminator" => MessageRole.Discriminator,
                "developer" => MessageRole.Developer,
                "tool" => MessageRole.Tool,
                _ => null,
            };
        }
    }
}