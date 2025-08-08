
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of response format being defined. Always `python`.
    /// </summary>
    public enum ResponseFormatTextPythonType
    {
        /// <summary>
        /// 
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatTextPythonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatTextPythonType value)
        {
            return value switch
            {
                ResponseFormatTextPythonType.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatTextPythonType? ToEnum(string value)
        {
            return value switch
            {
                "python" => ResponseFormatTextPythonType.Python,
                _ => null,
            };
        }
    }
}