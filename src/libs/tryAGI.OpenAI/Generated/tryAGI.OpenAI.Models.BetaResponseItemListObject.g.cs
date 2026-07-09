
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of object returned, must be `list`.
    /// </summary>
    public enum BetaResponseItemListObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseItemListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseItemListObject value)
        {
            return value switch
            {
                BetaResponseItemListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseItemListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => BetaResponseItemListObject.List,
                _ => null,
            };
        }
    }
}