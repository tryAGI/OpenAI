
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAnnotationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerFileCitation,
        /// <summary>
        /// 
        /// </summary>
        FileCitation,
        /// <summary>
        /// 
        /// </summary>
        FilePath,
        /// <summary>
        /// 
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnnotationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnnotationDiscriminatorType value)
        {
            return value switch
            {
                BetaAnnotationDiscriminatorType.ContainerFileCitation => "container_file_citation",
                BetaAnnotationDiscriminatorType.FileCitation => "file_citation",
                BetaAnnotationDiscriminatorType.FilePath => "file_path",
                BetaAnnotationDiscriminatorType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnnotationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => BetaAnnotationDiscriminatorType.ContainerFileCitation,
                "file_citation" => BetaAnnotationDiscriminatorType.FileCitation,
                "file_path" => BetaAnnotationDiscriminatorType.FilePath,
                "url_citation" => BetaAnnotationDiscriminatorType.UrlCitation,
                _ => null,
            };
        }
    }
}