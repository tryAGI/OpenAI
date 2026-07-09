
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the image generation call.
    /// </summary>
    public enum BetaImageGenToolCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Generating,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageGenToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolCallStatus value)
        {
            return value switch
            {
                BetaImageGenToolCallStatus.Completed => "completed",
                BetaImageGenToolCallStatus.Failed => "failed",
                BetaImageGenToolCallStatus.Generating => "generating",
                BetaImageGenToolCallStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaImageGenToolCallStatus.Completed,
                "failed" => BetaImageGenToolCallStatus.Failed,
                "generating" => BetaImageGenToolCallStatus.Generating,
                "in_progress" => BetaImageGenToolCallStatus.InProgress,
                _ => null,
            };
        }
    }
}