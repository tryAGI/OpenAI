
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the output text. Always `output_text`.
    /// </summary>
    public enum EvalItemContentVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalItemContentVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalItemContentVariant3Type value)
        {
            return value switch
            {
                EvalItemContentVariant3Type.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalItemContentVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => EvalItemContentVariant3Type.OutputText,
                _ => null,
            };
        }
    }
}