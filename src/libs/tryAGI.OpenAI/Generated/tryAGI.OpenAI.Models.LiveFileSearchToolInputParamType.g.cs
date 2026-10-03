
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: file_search
    /// </summary>
    public enum LiveFileSearchToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        FileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveFileSearchToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveFileSearchToolInputParamType value)
        {
            return value switch
            {
                LiveFileSearchToolInputParamType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveFileSearchToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => LiveFileSearchToolInputParamType.FileSearch,
                _ => null,
            };
        }
    }
}