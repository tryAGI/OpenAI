
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type of operation: `and` or `or`.
    /// </summary>
    public enum BetaCompoundFilterType
    {
        /// <summary>
        /// `and` or `or`.
        /// </summary>
        And,
        /// <summary>
        /// `and` or `or`.
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCompoundFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCompoundFilterType value)
        {
            return value switch
            {
                BetaCompoundFilterType.And => "and",
                BetaCompoundFilterType.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCompoundFilterType? ToEnum(string value)
        {
            return value switch
            {
                "and" => BetaCompoundFilterType.And,
                "or" => BetaCompoundFilterType.Or,
                _ => null,
            };
        }
    }
}