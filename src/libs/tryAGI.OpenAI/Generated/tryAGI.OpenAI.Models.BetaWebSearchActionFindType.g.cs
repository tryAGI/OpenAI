
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The action type.
    /// </summary>
    public enum BetaWebSearchActionFindType
    {
        /// <summary>
        ///
        /// </summary>
        FindInPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchActionFindTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchActionFindType value)
        {
            return value switch
            {
                BetaWebSearchActionFindType.FindInPage => "find_in_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchActionFindType? ToEnum(string value)
        {
            return value switch
            {
                "find_in_page" => BetaWebSearchActionFindType.FindInPage,
                _ => null,
            };
        }
    }
}