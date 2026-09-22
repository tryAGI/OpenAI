
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type. Always `output_text`.<br/>
    /// Default Value: output_text
    /// </summary>
    public enum OutputTextResourceType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputTextResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputTextResourceType value)
        {
            return value switch
            {
                OutputTextResourceType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputTextResourceType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => OutputTextResourceType.OutputText,
                _ => null,
            };
        }
    }
}