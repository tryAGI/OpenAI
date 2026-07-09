
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `input_text`.<br/>
    /// Default Value: input_text
    /// </summary>
    public enum BetaInputTextContentParamType
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputTextContentParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputTextContentParamType value)
        {
            return value switch
            {
                BetaInputTextContentParamType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputTextContentParamType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => BetaInputTextContentParamType.InputText,
                _ => null,
            };
        }
    }
}