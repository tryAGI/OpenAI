
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageBodyJsonParamModeration2
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageBodyJsonParamModeration2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamModeration2 value)
        {
            return value switch
            {
                EditImageBodyJsonParamModeration2.Low => "low",
                EditImageBodyJsonParamModeration2.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamModeration2? ToEnum(string value)
        {
            return value switch
            {
                "low" => EditImageBodyJsonParamModeration2.Low,
                "auto" => EditImageBodyJsonParamModeration2.Auto,
                _ => null,
            };
        }
    }
}