
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClickButtonType
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
    public static class ClickButtonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClickButtonType value)
        {
            return value switch
            {
                ClickButtonType.Back => "back",
                ClickButtonType.Forward => "forward",
                ClickButtonType.Left => "left",
                ClickButtonType.Right => "right",
                ClickButtonType.Wheel => "wheel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClickButtonType? ToEnum(string value)
        {
            return value switch
            {
                "back" => ClickButtonType.Back,
                "forward" => ClickButtonType.Forward,
                "left" => ClickButtonType.Left,
                "right" => ClickButtonType.Right,
                "wheel" => ClickButtonType.Wheel,
                _ => null,
            };
        }
    }
}