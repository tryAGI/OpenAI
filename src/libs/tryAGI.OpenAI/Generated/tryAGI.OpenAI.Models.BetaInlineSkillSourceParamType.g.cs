
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the inline skill source. Must be `base64`.<br/>
    /// Default Value: base64
    /// </summary>
    public enum BetaInlineSkillSourceParamType
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInlineSkillSourceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInlineSkillSourceParamType value)
        {
            return value switch
            {
                BetaInlineSkillSourceParamType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInlineSkillSourceParamType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => BetaInlineSkillSourceParamType.Base64,
                _ => null,
            };
        }
    }
}