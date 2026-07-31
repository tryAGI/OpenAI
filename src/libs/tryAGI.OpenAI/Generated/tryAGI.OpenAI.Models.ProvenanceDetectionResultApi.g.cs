
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProvenanceDetectionResultApi
    {
        /// <summary>
        /// 
        /// </summary>
        Detected,
        /// <summary>
        /// 
        /// </summary>
        NotDetected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProvenanceDetectionResultApiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvenanceDetectionResultApi value)
        {
            return value switch
            {
                ProvenanceDetectionResultApi.Detected => "detected",
                ProvenanceDetectionResultApi.NotDetected => "not_detected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvenanceDetectionResultApi? ToEnum(string value)
        {
            return value switch
            {
                "detected" => ProvenanceDetectionResultApi.Detected,
                "not_detected" => ProvenanceDetectionResultApi.NotDetected,
                _ => null,
            };
        }
    }
}