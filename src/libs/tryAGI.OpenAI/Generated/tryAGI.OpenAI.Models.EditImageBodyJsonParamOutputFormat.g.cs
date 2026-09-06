
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EditImageBodyJsonParamOutputFormat
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
    public static class EditImageBodyJsonParamOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamOutputFormat value)
        {
            return value switch
            {
                EditImageBodyJsonParamOutputFormat.Jpeg => "jpeg",
                EditImageBodyJsonParamOutputFormat.Png => "png",
                EditImageBodyJsonParamOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => EditImageBodyJsonParamOutputFormat.Jpeg,
                "png" => EditImageBodyJsonParamOutputFormat.Png,
                "webp" => EditImageBodyJsonParamOutputFormat.Webp,
                _ => null,
            };
        }
    }
}