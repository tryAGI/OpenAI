
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomToolParamFormatDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolParamFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolParamFormatDiscriminatorType value)
        {
            return value switch
            {
                CustomToolParamFormatDiscriminatorType.Grammar => "grammar",
                CustomToolParamFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolParamFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => CustomToolParamFormatDiscriminatorType.Grammar,
                "text" => CustomToolParamFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}