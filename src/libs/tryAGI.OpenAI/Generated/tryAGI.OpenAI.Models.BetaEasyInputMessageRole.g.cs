
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The role of the message input. One of `user`, `assistant`, `system`, or<br/>
    /// `developer`.
    /// </summary>
    public enum BetaEasyInputMessageRole
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
    public static class BetaEasyInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaEasyInputMessageRole value)
        {
            return value switch
            {
                BetaEasyInputMessageRole.Assistant => "assistant",
                BetaEasyInputMessageRole.Developer => "developer",
                BetaEasyInputMessageRole.System => "system",
                BetaEasyInputMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaEasyInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BetaEasyInputMessageRole.Assistant,
                "developer" => BetaEasyInputMessageRole.Developer,
                "system" => BetaEasyInputMessageRole.System,
                "user" => BetaEasyInputMessageRole.User,
                _ => null,
            };
        }
    }
}