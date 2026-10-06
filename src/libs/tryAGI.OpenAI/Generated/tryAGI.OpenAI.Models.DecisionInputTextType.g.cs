
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: input_text
    /// </summary>
    public enum DecisionInputTextType
    {
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputTextType value)
        {
            return value switch
            {
                DecisionInputTextType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputTextType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => DecisionInputTextType.InputText,
                _ => null,
            };
        }
    }
}