
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Unconstrained text format. Always `text`.
    /// </summary>
    public enum CustomToolFormatVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolFormatVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolFormatVariant1Type value)
        {
            return value switch
            {
                CustomToolFormatVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolFormatVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => CustomToolFormatVariant1Type.Text,
                _ => null,
            };
        }
    }
}