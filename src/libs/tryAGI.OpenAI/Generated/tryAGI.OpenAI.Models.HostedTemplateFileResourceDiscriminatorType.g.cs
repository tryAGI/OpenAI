
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedTemplateFileResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        FileId,
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedTemplateFileResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedTemplateFileResourceDiscriminatorType value)
        {
            return value switch
            {
                HostedTemplateFileResourceDiscriminatorType.FileId => "file_id",
                HostedTemplateFileResourceDiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedTemplateFileResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => HostedTemplateFileResourceDiscriminatorType.FileId,
                "inline" => HostedTemplateFileResourceDiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}