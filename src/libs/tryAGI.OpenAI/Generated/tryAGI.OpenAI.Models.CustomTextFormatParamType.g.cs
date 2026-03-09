
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Unconstrained text format. Always `text`.<br/>
    /// Default Value: text
    /// </summary>
    public enum CustomTextFormatParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomTextFormatParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomTextFormatParamType value)
        {
            return value switch
            {
                CustomTextFormatParamType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomTextFormatParamType? ToEnum(string value)
        {
            return value switch
            {
                "text" => CustomTextFormatParamType.Text,
                _ => null,
            };
        }
    }
}