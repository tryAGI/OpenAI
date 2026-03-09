
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `file`.<br/>
    /// Default Value: file
    /// </summary>
    public enum FileAnnotationSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileAnnotationSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileAnnotationSourceType value)
        {
            return value switch
            {
                FileAnnotationSourceType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileAnnotationSourceType? ToEnum(string value)
        {
            return value switch
            {
                "file" => FileAnnotationSourceType.File,
                _ => null,
            };
        }
    }
}