
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the file search tool. Always `file_search`.<br/>
    /// Default Value: file_search
    /// </summary>
    public enum BetaFileSearchToolType
    {
        /// <summary>
        ///
        /// </summary>
        FileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFileSearchToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFileSearchToolType value)
        {
            return value switch
            {
                BetaFileSearchToolType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFileSearchToolType? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => BetaFileSearchToolType.FileSearch,
                _ => null,
            };
        }
    }
}