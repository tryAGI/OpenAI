
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaOutputTextContentParamAnnotationDiscriminatorType
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
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOutputTextContentParamAnnotationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputTextContentParamAnnotationDiscriminatorType value)
        {
            return value switch
            {
                BetaOutputTextContentParamAnnotationDiscriminatorType.ContainerFileCitation => "container_file_citation",
                BetaOutputTextContentParamAnnotationDiscriminatorType.FileCitation => "file_citation",
                BetaOutputTextContentParamAnnotationDiscriminatorType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputTextContentParamAnnotationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => BetaOutputTextContentParamAnnotationDiscriminatorType.ContainerFileCitation,
                "file_citation" => BetaOutputTextContentParamAnnotationDiscriminatorType.FileCitation,
                "url_citation" => BetaOutputTextContentParamAnnotationDiscriminatorType.UrlCitation,
                _ => null,
            };
        }
    }
}