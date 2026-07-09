
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaWebSearchToolCallActionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        FindInPage,
        /// <summary>
        /// 
        /// </summary>
        OpenPage,
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchToolCallActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchToolCallActionDiscriminatorType value)
        {
            return value switch
            {
                BetaWebSearchToolCallActionDiscriminatorType.FindInPage => "find_in_page",
                BetaWebSearchToolCallActionDiscriminatorType.OpenPage => "open_page",
                BetaWebSearchToolCallActionDiscriminatorType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchToolCallActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "find_in_page" => BetaWebSearchToolCallActionDiscriminatorType.FindInPage,
                "open_page" => BetaWebSearchToolCallActionDiscriminatorType.OpenPage,
                "search" => BetaWebSearchToolCallActionDiscriminatorType.Search,
                _ => null,
            };
        }
    }
}