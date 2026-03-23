
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
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Low,
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
                EditImageBodyJsonParamModeration2.Auto => "auto",
                EditImageBodyJsonParamModeration2.Low => "low",
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
                "auto" => EditImageBodyJsonParamModeration2.Auto,
                "low" => EditImageBodyJsonParamModeration2.Low,
                _ => null,
            };
        }
    }
}