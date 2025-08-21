
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the file citation. Always `file_citation`.<br/>
    /// Default Value: file_citation
    /// </summary>
    public enum FileCitationBody2Type
    {
        /// <summary>
        /// 
        /// </summary>
        FileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileCitationBody2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileCitationBody2Type value)
        {
            return value switch
            {
                FileCitationBody2Type.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileCitationBody2Type? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => FileCitationBody2Type.FileCitation,
                _ => null,
            };
        }
    }
}