
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The media type of the inline skill payload. Must be `application/zip`.<br/>
    /// Default Value: application/zip
    /// </summary>
    public enum InlineSkillSourceParamMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationZip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InlineSkillSourceParamMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InlineSkillSourceParamMediaType value)
        {
            return value switch
            {
                InlineSkillSourceParamMediaType.ApplicationZip => "application/zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InlineSkillSourceParamMediaType? ToEnum(string value)
        {
            return value switch
            {
                "application/zip" => InlineSkillSourceParamMediaType.ApplicationZip,
                _ => null,
            };
        }
    }
}