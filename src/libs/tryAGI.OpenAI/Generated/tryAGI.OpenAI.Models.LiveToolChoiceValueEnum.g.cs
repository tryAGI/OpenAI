
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveToolChoiceValueEnum
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveToolChoiceValueEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveToolChoiceValueEnum value)
        {
            return value switch
            {
                LiveToolChoiceValueEnum.Auto => "auto",
                LiveToolChoiceValueEnum.None => "none",
                LiveToolChoiceValueEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveToolChoiceValueEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => LiveToolChoiceValueEnum.Auto,
                "none" => LiveToolChoiceValueEnum.None,
                "required" => LiveToolChoiceValueEnum.Required,
                _ => null,
            };
        }
    }
}