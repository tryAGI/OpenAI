
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: removed
    /// </summary>
    public enum ReasoningInputTransformationAction
    {
        /// <summary>
        ///
        /// </summary>
        Removed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningInputTransformationActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningInputTransformationAction value)
        {
            return value switch
            {
                ReasoningInputTransformationAction.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningInputTransformationAction? ToEnum(string value)
        {
            return value switch
            {
                "removed" => ReasoningInputTransformationAction.Removed,
                _ => null,
            };
        }
    }
}