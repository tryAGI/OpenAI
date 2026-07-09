
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the file search tool call. Always `file_search_call`.
    /// </summary>
    public enum BetaFileSearchToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFileSearchToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFileSearchToolCallType value)
        {
            return value switch
            {
                BetaFileSearchToolCallType.FileSearchCall => "file_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFileSearchToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "file_search_call" => BetaFileSearchToolCallType.FileSearchCall,
                _ => null,
            };
        }
    }
}