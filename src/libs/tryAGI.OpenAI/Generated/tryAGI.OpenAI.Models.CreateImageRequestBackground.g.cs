
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageRequestBackground
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
    public static class CreateImageRequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestBackground value)
        {
            return value switch
            {
                CreateImageRequestBackground.Auto => "auto",
                CreateImageRequestBackground.Opaque => "opaque",
                CreateImageRequestBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageRequestBackground.Auto,
                "opaque" => CreateImageRequestBackground.Opaque,
                "transparent" => CreateImageRequestBackground.Transparent,
                _ => null,
            };
        }
    }
}