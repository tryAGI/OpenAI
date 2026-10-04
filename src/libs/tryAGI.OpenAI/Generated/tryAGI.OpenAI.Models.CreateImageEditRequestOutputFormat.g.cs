
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageEditRequestOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Jpeg,
        /// <summary>
        ///
        /// </summary>
        Png,
        /// <summary>
        ///
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestOutputFormat value)
        {
            return value switch
            {
                CreateImageEditRequestOutputFormat.Jpeg => "jpeg",
                CreateImageEditRequestOutputFormat.Png => "png",
                CreateImageEditRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateImageEditRequestOutputFormat.Jpeg,
                "png" => CreateImageEditRequestOutputFormat.Png,
                "webp" => CreateImageEditRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}