
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `file` for this annotation.<br/>
    /// Default Value: file
    /// </summary>
    public enum FileAnnotationType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileAnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileAnnotationType value)
        {
            return value switch
            {
                FileAnnotationType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileAnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "file" => FileAnnotationType.File,
                _ => null,
            };
        }
    }
}