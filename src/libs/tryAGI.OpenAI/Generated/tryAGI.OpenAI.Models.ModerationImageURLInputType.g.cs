
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `image_url`.
    /// </summary>
    public enum ModerationImageURLInputType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationImageURLInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationImageURLInputType value)
        {
            return value switch
            {
                ModerationImageURLInputType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationImageURLInputType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ModerationImageURLInputType.ImageUrl,
                _ => null,
            };
        }
    }
}