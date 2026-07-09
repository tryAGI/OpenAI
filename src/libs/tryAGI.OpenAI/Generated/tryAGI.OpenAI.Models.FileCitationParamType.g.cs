
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The citation type. Always `file_citation`.<br/>
    /// Default Value: file_citation
    /// </summary>
    public enum FileCitationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        FileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileCitationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileCitationParamType value)
        {
            return value switch
            {
                FileCitationParamType.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileCitationParamType? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => FileCitationParamType.FileCitation,
                _ => null,
            };
        }
    }
}