
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileDetailEnum
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileDetailEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileDetailEnum value)
        {
            return value switch
            {
                FileDetailEnum.High => "high",
                FileDetailEnum.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileDetailEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => FileDetailEnum.High,
                "low" => FileDetailEnum.Low,
                _ => null,
            };
        }
    }
}