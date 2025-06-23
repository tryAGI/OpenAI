
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the output. Always 'image'.<br/>
    /// Default Value: image
    /// </summary>
    public enum CodeInterpreterOutputImageType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterOutputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterOutputImageType value)
        {
            return value switch
            {
                CodeInterpreterOutputImageType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterOutputImageType? ToEnum(string value)
        {
            return value switch
            {
                "image" => CodeInterpreterOutputImageType.Image,
                _ => null,
            };
        }
    }
}