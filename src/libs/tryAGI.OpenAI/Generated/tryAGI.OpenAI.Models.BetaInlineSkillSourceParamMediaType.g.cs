
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The media type of the inline skill payload. Must be `application/zip`.<br/>
    /// Default Value: application/zip
    /// </summary>
    public enum BetaInlineSkillSourceParamMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationZip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInlineSkillSourceParamMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInlineSkillSourceParamMediaType value)
        {
            return value switch
            {
                BetaInlineSkillSourceParamMediaType.ApplicationZip => "application/zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInlineSkillSourceParamMediaType? ToEnum(string value)
        {
            return value switch
            {
                "application/zip" => BetaInlineSkillSourceParamMediaType.ApplicationZip,
                _ => null,
            };
        }
    }
}