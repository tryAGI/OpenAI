
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The role of the output message. Always `assistant`.
    /// </summary>
    public enum BetaOutputMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOutputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputMessageRole value)
        {
            return value switch
            {
                BetaOutputMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BetaOutputMessageRole.Assistant,
                _ => null,
            };
        }
    }
}