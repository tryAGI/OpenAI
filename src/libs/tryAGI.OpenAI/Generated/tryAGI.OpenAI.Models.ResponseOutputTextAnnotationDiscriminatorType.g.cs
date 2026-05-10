
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOutputTextAnnotationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputTextAnnotationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputTextAnnotationDiscriminatorType value)
        {
            return value switch
            {
                ResponseOutputTextAnnotationDiscriminatorType.File => "file",
                ResponseOutputTextAnnotationDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputTextAnnotationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => ResponseOutputTextAnnotationDiscriminatorType.File,
                "url" => ResponseOutputTextAnnotationDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}