
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type of this resource - always set to `response`.
    /// </summary>
    public enum BetaResponseVariant3Object
    {
        /// <summary>
        ///
        /// </summary>
        Response,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseVariant3ObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseVariant3Object value)
        {
            return value switch
            {
                BetaResponseVariant3Object.Response => "response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseVariant3Object? ToEnum(string value)
        {
            return value switch
            {
                "response" => BetaResponseVariant3Object.Response,
                _ => null,
            };
        }
    }
}