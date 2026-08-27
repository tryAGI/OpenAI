
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Allowed tool configuration type. Always `allowed_tools`.
    /// </summary>
    public enum BetaToolChoiceAllowedType
    {
        /// <summary>
        ///
        /// </summary>
        AllowedTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolChoiceAllowedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolChoiceAllowedType value)
        {
            return value switch
            {
                BetaToolChoiceAllowedType.AllowedTools => "allowed_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolChoiceAllowedType? ToEnum(string value)
        {
            return value switch
            {
                "allowed_tools" => BetaToolChoiceAllowedType.AllowedTools,
                _ => null,
            };
        }
    }
}