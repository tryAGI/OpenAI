
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageBodyJsonParamBackground2
    {
        /// <summary>
        /// 
        /// </summary>
        Transparent,
        /// <summary>
        /// 
        /// </summary>
        Opaque,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageBodyJsonParamBackground2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamBackground2 value)
        {
            return value switch
            {
                EditImageBodyJsonParamBackground2.Transparent => "transparent",
                EditImageBodyJsonParamBackground2.Opaque => "opaque",
                EditImageBodyJsonParamBackground2.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamBackground2? ToEnum(string value)
        {
            return value switch
            {
                "transparent" => EditImageBodyJsonParamBackground2.Transparent,
                "opaque" => EditImageBodyJsonParamBackground2.Opaque,
                "auto" => EditImageBodyJsonParamBackground2.Auto,
                _ => null,
            };
        }
    }
}