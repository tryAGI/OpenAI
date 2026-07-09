
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The citation type. Always `file_citation`.<br/>
    /// Default Value: file_citation
    /// </summary>
    public enum BetaFileCitationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        FileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFileCitationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFileCitationParamType value)
        {
            return value switch
            {
                BetaFileCitationParamType.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFileCitationParamType? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => BetaFileCitationParamType.FileCitation,
                _ => null,
            };
        }
    }
}