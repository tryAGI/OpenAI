
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The media type of the inline skill payload. Must be `application/zip`.<br/>
    /// Default Value: application/zip
    /// </summary>
    public enum LiveInlineSkillSourceParamMediaType
    {
        /// <summary>
        ///
        /// </summary>
        ApplicationZip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInlineSkillSourceParamMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInlineSkillSourceParamMediaType value)
        {
            return value switch
            {
                LiveInlineSkillSourceParamMediaType.ApplicationZip => "application/zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInlineSkillSourceParamMediaType? ToEnum(string value)
        {
            return value switch
            {
                "application/zip" => LiveInlineSkillSourceParamMediaType.ApplicationZip,
                _ => null,
            };
        }
    }
}