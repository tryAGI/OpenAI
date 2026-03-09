
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageBodyJsonParamSize2
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        x1536x1024,
        /// <summary>
        /// 
        /// </summary>
        x1024x1536,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageBodyJsonParamSize2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamSize2 value)
        {
            return value switch
            {
                EditImageBodyJsonParamSize2.Auto => "auto",
                EditImageBodyJsonParamSize2.x1024x1024 => "1024x1024",
                EditImageBodyJsonParamSize2.x1536x1024 => "1536x1024",
                EditImageBodyJsonParamSize2.x1024x1536 => "1024x1536",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamSize2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EditImageBodyJsonParamSize2.Auto,
                "1024x1024" => EditImageBodyJsonParamSize2.x1024x1024,
                "1536x1024" => EditImageBodyJsonParamSize2.x1536x1024,
                "1024x1536" => EditImageBodyJsonParamSize2.x1024x1536,
                _ => null,
            };
        }
    }
}