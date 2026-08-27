
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type. Always `output_text`.<br/>
    /// Default Value: output_text
    /// </summary>
    public enum BetaOutputTextContentParamType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOutputTextContentParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputTextContentParamType value)
        {
            return value switch
            {
                BetaOutputTextContentParamType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputTextContentParamType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => BetaOutputTextContentParamType.OutputText,
                _ => null,
            };
        }
    }
}