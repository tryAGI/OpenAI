
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `file_id`.<br/>
    /// Default Value: file_id
    /// </summary>
    public enum HostedTemplateFileResourceFileIdType
    {
        /// <summary>
        ///
        /// </summary>
        FileId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedTemplateFileResourceFileIdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedTemplateFileResourceFileIdType value)
        {
            return value switch
            {
                HostedTemplateFileResourceFileIdType.FileId => "file_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedTemplateFileResourceFileIdType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => HostedTemplateFileResourceFileIdType.FileId,
                _ => null,
            };
        }
    }
}