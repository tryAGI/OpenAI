
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Defines an inline skill for this request.<br/>
    /// Default Value: inline
    /// </summary>
    public enum BetaInlineSkillParamType
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInlineSkillParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInlineSkillParamType value)
        {
            return value switch
            {
                BetaInlineSkillParamType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInlineSkillParamType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => BetaInlineSkillParamType.Inline,
                _ => null,
            };
        }
    }
}