
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EditImageBodyJsonParamModeration
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
    public static class EditImageBodyJsonParamModerationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamModeration value)
        {
            return value switch
            {
                EditImageBodyJsonParamModeration.Auto => "auto",
                EditImageBodyJsonParamModeration.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamModeration? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EditImageBodyJsonParamModeration.Auto,
                "low" => EditImageBodyJsonParamModeration.Low,
                _ => null,
            };
        }
    }
}