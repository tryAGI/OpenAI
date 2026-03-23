
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageBodyJsonParamOutputFormat2
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
    public static class EditImageBodyJsonParamOutputFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamOutputFormat2 value)
        {
            return value switch
            {
                EditImageBodyJsonParamOutputFormat2.Jpeg => "jpeg",
                EditImageBodyJsonParamOutputFormat2.Png => "png",
                EditImageBodyJsonParamOutputFormat2.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamOutputFormat2? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => EditImageBodyJsonParamOutputFormat2.Jpeg,
                "png" => EditImageBodyJsonParamOutputFormat2.Png,
                "webp" => EditImageBodyJsonParamOutputFormat2.Webp,
                _ => null,
            };
        }
    }
}