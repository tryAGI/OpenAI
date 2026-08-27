
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClickButtonType
    {
        /// <summary>
        ///
        /// </summary>
        Back,
        /// <summary>
        ///
        /// </summary>
        Forward,
        /// <summary>
        ///
        /// </summary>
        Left,
        /// <summary>
        ///
        /// </summary>
        Right,
        /// <summary>
        ///
        /// </summary>
        Wheel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClickButtonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClickButtonType value)
        {
            return value switch
            {
                BetaClickButtonType.Back => "back",
                BetaClickButtonType.Forward => "forward",
                BetaClickButtonType.Left => "left",
                BetaClickButtonType.Right => "right",
                BetaClickButtonType.Wheel => "wheel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClickButtonType? ToEnum(string value)
        {
            return value switch
            {
                "back" => BetaClickButtonType.Back,
                "forward" => BetaClickButtonType.Forward,
                "left" => BetaClickButtonType.Left,
                "right" => BetaClickButtonType.Right,
                "wheel" => BetaClickButtonType.Wheel,
                _ => null,
            };
        }
    }
}