
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveToolChoiceEnum
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
    public static class LiveToolChoiceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveToolChoiceEnum value)
        {
            return value switch
            {
                LiveToolChoiceEnum.Auto => "auto",
                LiveToolChoiceEnum.None => "none",
                LiveToolChoiceEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveToolChoiceEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => LiveToolChoiceEnum.Auto,
                "none" => LiveToolChoiceEnum.None,
                "required" => LiveToolChoiceEnum.Required,
                _ => null,
            };
        }
    }
}