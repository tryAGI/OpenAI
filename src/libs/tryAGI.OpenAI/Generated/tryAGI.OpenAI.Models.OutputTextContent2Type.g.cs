
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the output text. Always `output_text`.<br/>
    /// Default Value: output_text
    /// </summary>
    public enum OutputTextContent2Type
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputTextContent2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputTextContent2Type value)
        {
            return value switch
            {
                OutputTextContent2Type.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputTextContent2Type? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => OutputTextContent2Type.OutputText,
                _ => null,
            };
        }
    }
}