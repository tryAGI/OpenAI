
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaModerationInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaModerationInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaModerationInputType value)
        {
            return value switch
            {
                BetaModerationInputType.Image => "image",
                BetaModerationInputType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaModerationInputType? ToEnum(string value)
        {
            return value switch
            {
                "image" => BetaModerationInputType.Image,
                "text" => BetaModerationInputType.Text,
                _ => null,
            };
        }
    }
}