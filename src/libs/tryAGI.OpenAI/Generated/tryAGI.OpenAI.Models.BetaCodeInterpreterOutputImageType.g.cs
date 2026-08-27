
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the output. Always `image`.<br/>
    /// Default Value: image
    /// </summary>
    public enum BetaCodeInterpreterOutputImageType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCodeInterpreterOutputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeInterpreterOutputImageType value)
        {
            return value switch
            {
                BetaCodeInterpreterOutputImageType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCodeInterpreterOutputImageType? ToEnum(string value)
        {
            return value switch
            {
                "image" => BetaCodeInterpreterOutputImageType.Image,
                _ => null,
            };
        }
    }
}