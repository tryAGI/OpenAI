
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaMessageRole
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
    public static class BetaMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageRole value)
        {
            return value switch
            {
                BetaMessageRole.Assistant => "assistant",
                BetaMessageRole.Critic => "critic",
                BetaMessageRole.Developer => "developer",
                BetaMessageRole.Discriminator => "discriminator",
                BetaMessageRole.System => "system",
                BetaMessageRole.Tool => "tool",
                BetaMessageRole.Unknown => "unknown",
                BetaMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BetaMessageRole.Assistant,
                "critic" => BetaMessageRole.Critic,
                "developer" => BetaMessageRole.Developer,
                "discriminator" => BetaMessageRole.Discriminator,
                "system" => BetaMessageRole.System,
                "tool" => BetaMessageRole.Tool,
                "unknown" => BetaMessageRole.Unknown,
                "user" => BetaMessageRole.User,
                _ => null,
            };
        }
    }
}