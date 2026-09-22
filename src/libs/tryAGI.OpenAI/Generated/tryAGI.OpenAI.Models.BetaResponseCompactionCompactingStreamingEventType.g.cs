
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event, always `response.compaction.compacting`.<br/>
    /// Default Value: response.compaction.compacting
    /// </summary>
    public enum BetaResponseCompactionCompactingStreamingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCompactionCompacting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCompactionCompactingStreamingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCompactionCompactingStreamingEventType value)
        {
            return value switch
            {
                BetaResponseCompactionCompactingStreamingEventType.ResponseCompactionCompacting => "response.compaction.compacting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCompactionCompactingStreamingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.compaction.compacting" => BetaResponseCompactionCompactingStreamingEventType.ResponseCompactionCompacting,
                _ => null,
            };
        }
    }
}