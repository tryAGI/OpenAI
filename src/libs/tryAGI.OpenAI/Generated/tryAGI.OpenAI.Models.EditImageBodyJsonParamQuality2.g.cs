
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageBodyJsonParamQuality2
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
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageBodyJsonParamQuality2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamQuality2 value)
        {
            return value switch
            {
                EditImageBodyJsonParamQuality2.Auto => "auto",
                EditImageBodyJsonParamQuality2.High => "high",
                EditImageBodyJsonParamQuality2.Low => "low",
                EditImageBodyJsonParamQuality2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamQuality2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EditImageBodyJsonParamQuality2.Auto,
                "high" => EditImageBodyJsonParamQuality2.High,
                "low" => EditImageBodyJsonParamQuality2.Low,
                "medium" => EditImageBodyJsonParamQuality2.Medium,
                _ => null,
            };
        }
    }
}