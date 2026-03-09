
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
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Auto,
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
                EditImageBodyJsonParamQuality2.Low => "low",
                EditImageBodyJsonParamQuality2.Medium => "medium",
                EditImageBodyJsonParamQuality2.High => "high",
                EditImageBodyJsonParamQuality2.Auto => "auto",
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
                "low" => EditImageBodyJsonParamQuality2.Low,
                "medium" => EditImageBodyJsonParamQuality2.Medium,
                "high" => EditImageBodyJsonParamQuality2.High,
                "auto" => EditImageBodyJsonParamQuality2.Auto,
                _ => null,
            };
        }
    }
}