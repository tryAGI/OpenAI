
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageGenActionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        Generate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenActionEnum value)
        {
            return value switch
            {
                ImageGenActionEnum.Auto => "auto",
                ImageGenActionEnum.Edit => "edit",
                ImageGenActionEnum.Generate => "generate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageGenActionEnum.Auto,
                "edit" => ImageGenActionEnum.Edit,
                "generate" => ImageGenActionEnum.Generate,
                _ => null,
            };
        }
    }
}