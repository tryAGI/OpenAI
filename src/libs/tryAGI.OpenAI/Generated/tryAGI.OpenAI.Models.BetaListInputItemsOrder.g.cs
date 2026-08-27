
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListInputItemsOrder
    {
        /// <summary>
        /// Return the input items in ascending order.
        /// </summary>
        Asc,
        /// <summary>
        /// Return the input items in descending order.
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaListInputItemsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListInputItemsOrder value)
        {
            return value switch
            {
                BetaListInputItemsOrder.Asc => "asc",
                BetaListInputItemsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListInputItemsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaListInputItemsOrder.Asc,
                "desc" => BetaListInputItemsOrder.Desc,
                _ => null,
            };
        }
    }
}