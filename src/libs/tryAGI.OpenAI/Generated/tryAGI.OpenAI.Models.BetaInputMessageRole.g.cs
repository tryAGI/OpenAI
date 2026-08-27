
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The role of the message input. One of `user`, `system`, or `developer`.
    /// </summary>
    public enum BetaInputMessageRole
    {
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
    public static class BetaInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputMessageRole value)
        {
            return value switch
            {
                BetaInputMessageRole.Developer => "developer",
                BetaInputMessageRole.System => "system",
                BetaInputMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => BetaInputMessageRole.Developer,
                "system" => BetaInputMessageRole.System,
                "user" => BetaInputMessageRole.User,
                _ => null,
            };
        }
    }
}