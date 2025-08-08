
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Grammar format. Always `grammar`.
    /// </summary>
    public enum CustomToolFormatVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolFormatVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolFormatVariant2Type value)
        {
            return value switch
            {
                CustomToolFormatVariant2Type.Grammar => "grammar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolFormatVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => CustomToolFormatVariant2Type.Grammar,
                _ => null,
            };
        }
    }
}