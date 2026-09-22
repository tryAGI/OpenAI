
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EditImageBodyJsonParamQuality
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageBodyJsonParamQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamQuality value)
        {
            return value switch
            {
                EditImageBodyJsonParamQuality.Auto => "auto",
                EditImageBodyJsonParamQuality.High => "high",
                EditImageBodyJsonParamQuality.Low => "low",
                EditImageBodyJsonParamQuality.Max => "max",
                EditImageBodyJsonParamQuality.Medium => "medium",
                EditImageBodyJsonParamQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EditImageBodyJsonParamQuality.Auto,
                "high" => EditImageBodyJsonParamQuality.High,
                "low" => EditImageBodyJsonParamQuality.Low,
                "max" => EditImageBodyJsonParamQuality.Max,
                "medium" => EditImageBodyJsonParamQuality.Medium,
                "xhigh" => EditImageBodyJsonParamQuality.Xhigh,
                _ => null,
            };
        }
    }
}