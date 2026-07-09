
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The action type.
    /// </summary>
    public enum BetaWebSearchActionOpenPageType
    {
        /// <summary>
        /// 
        /// </summary>
        OpenPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchActionOpenPageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchActionOpenPageType value)
        {
            return value switch
            {
                BetaWebSearchActionOpenPageType.OpenPage => "open_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchActionOpenPageType? ToEnum(string value)
        {
            return value switch
            {
                "open_page" => BetaWebSearchActionOpenPageType.OpenPage,
                _ => null,
            };
        }
    }
}