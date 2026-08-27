
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `input_image`.<br/>
    /// Default Value: input_image
    /// </summary>
    public enum BetaInputImageContentParamAutoParamType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputImageContentParamAutoParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputImageContentParamAutoParamType value)
        {
            return value switch
            {
                BetaInputImageContentParamAutoParamType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputImageContentParamAutoParamType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => BetaInputImageContentParamAutoParamType.InputImage,
                _ => null,
            };
        }
    }
}