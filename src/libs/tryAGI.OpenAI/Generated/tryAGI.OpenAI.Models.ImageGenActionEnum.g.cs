
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
        Generate,
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        Auto,
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
                ImageGenActionEnum.Generate => "generate",
                ImageGenActionEnum.Edit => "edit",
                ImageGenActionEnum.Auto => "auto",
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
                "generate" => ImageGenActionEnum.Generate,
                "edit" => ImageGenActionEnum.Edit,
                "auto" => ImageGenActionEnum.Auto,
                _ => null,
            };
        }
    }
}