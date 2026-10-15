
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: output_text
    /// </summary>
    public enum DecisionInputOutputTextType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputOutputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputOutputTextType value)
        {
            return value switch
            {
                DecisionInputOutputTextType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputOutputTextType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => DecisionInputOutputTextType.OutputText,
                _ => null,
            };
        }
    }
}