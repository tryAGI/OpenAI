
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of source. Always `url`.
    /// </summary>
    public enum BetaWebSearchActionSearchSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchActionSearchSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchActionSearchSourceType value)
        {
            return value switch
            {
                BetaWebSearchActionSearchSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchActionSearchSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => BetaWebSearchActionSearchSourceType.Url,
                _ => null,
            };
        }
    }
}