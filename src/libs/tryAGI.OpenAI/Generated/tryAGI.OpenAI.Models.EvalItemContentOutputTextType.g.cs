
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the output text. Always `output_text`.
    /// </summary>
    public enum EvalItemContentOutputTextType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalItemContentOutputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalItemContentOutputTextType value)
        {
            return value switch
            {
                EvalItemContentOutputTextType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalItemContentOutputTextType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => EvalItemContentOutputTextType.OutputText,
                _ => null,
            };
        }
    }
}