
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the file path. Always `file_path`.
    /// </summary>
    public enum BetaFilePathType
    {
        /// <summary>
        ///
        /// </summary>
        FilePath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFilePathTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFilePathType value)
        {
            return value switch
            {
                BetaFilePathType.FilePath => "file_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFilePathType? ToEnum(string value)
        {
            return value switch
            {
                "file_path" => BetaFilePathType.FilePath,
                _ => null,
            };
        }
    }
}