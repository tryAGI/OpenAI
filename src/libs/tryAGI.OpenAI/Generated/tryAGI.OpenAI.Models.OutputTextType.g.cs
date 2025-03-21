
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the output text. Always `output_text`.
    /// </summary>
    public enum OutputTextType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputTextType value)
        {
            return value switch
            {
                OutputTextType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputTextType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => OutputTextType.OutputText,
                _ => null,
            };
        }
    }
}