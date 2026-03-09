
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the inline skill source. Must be `base64`.<br/>
    /// Default Value: base64
    /// </summary>
    public enum InlineSkillSourceParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InlineSkillSourceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InlineSkillSourceParamType value)
        {
            return value switch
            {
                InlineSkillSourceParamType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InlineSkillSourceParamType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => InlineSkillSourceParamType.Base64,
                _ => null,
            };
        }
    }
}