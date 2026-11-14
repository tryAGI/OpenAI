
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: reasoning
    /// </summary>
    public enum ReasoningInputTransformationType
    {
        /// <summary>
        ///
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningInputTransformationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningInputTransformationType value)
        {
            return value switch
            {
                ReasoningInputTransformationType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningInputTransformationType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning" => ReasoningInputTransformationType.Reasoning,
                _ => null,
            };
        }
    }
}