
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageEditRequestBackground
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Opaque,
        /// <summary>
        ///
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestBackground value)
        {
            return value switch
            {
                CreateImageEditRequestBackground.Auto => "auto",
                CreateImageEditRequestBackground.Opaque => "opaque",
                CreateImageEditRequestBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageEditRequestBackground.Auto,
                "opaque" => CreateImageEditRequestBackground.Opaque,
                "transparent" => CreateImageEditRequestBackground.Transparent,
                _ => null,
            };
        }
    }
}