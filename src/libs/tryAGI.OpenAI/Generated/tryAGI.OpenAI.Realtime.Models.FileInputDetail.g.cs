
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileInputDetail
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
    public static class FileInputDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileInputDetail value)
        {
            return value switch
            {
                FileInputDetail.High => "high",
                FileInputDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileInputDetail? ToEnum(string value)
        {
            return value switch
            {
                "high" => FileInputDetail.High,
                "low" => FileInputDetail.Low,
                _ => null,
            };
        }
    }
}