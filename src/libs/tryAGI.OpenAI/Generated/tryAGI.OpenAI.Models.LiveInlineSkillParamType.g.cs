
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Defines an inline skill for this request.<br/>
    /// Default Value: inline
    /// </summary>
    public enum LiveInlineSkillParamType
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInlineSkillParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInlineSkillParamType value)
        {
            return value switch
            {
                LiveInlineSkillParamType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInlineSkillParamType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => LiveInlineSkillParamType.Inline,
                _ => null,
            };
        }
    }
}