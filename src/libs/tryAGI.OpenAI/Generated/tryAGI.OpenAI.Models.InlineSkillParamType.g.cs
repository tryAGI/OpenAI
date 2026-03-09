
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Defines an inline skill for this request.<br/>
    /// Default Value: inline
    /// </summary>
    public enum InlineSkillParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InlineSkillParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InlineSkillParamType value)
        {
            return value switch
            {
                InlineSkillParamType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InlineSkillParamType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => InlineSkillParamType.Inline,
                _ => null,
            };
        }
    }
}