
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EditImageBodyJsonParamBackground
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
    public static class EditImageBodyJsonParamBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamBackground value)
        {
            return value switch
            {
                EditImageBodyJsonParamBackground.Auto => "auto",
                EditImageBodyJsonParamBackground.Opaque => "opaque",
                EditImageBodyJsonParamBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EditImageBodyJsonParamBackground.Auto,
                "opaque" => EditImageBodyJsonParamBackground.Opaque,
                "transparent" => EditImageBodyJsonParamBackground.Transparent,
                _ => null,
            };
        }
    }
}