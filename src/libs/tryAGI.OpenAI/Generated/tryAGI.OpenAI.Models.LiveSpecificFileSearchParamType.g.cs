
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `file_search`.<br/>
    /// Default Value: file_search
    /// </summary>
    public enum LiveSpecificFileSearchParamType
    {
        /// <summary>
        ///
        /// </summary>
        FileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpecificFileSearchParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpecificFileSearchParamType value)
        {
            return value switch
            {
                LiveSpecificFileSearchParamType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpecificFileSearchParamType? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => LiveSpecificFileSearchParamType.FileSearch,
                _ => null,
            };
        }
    }
}