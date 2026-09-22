
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveResponsesServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        FastTierTempPilot,
        /// <summary>
        ///
        /// </summary>
        Flex,
        /// <summary>
        ///
        /// </summary>
        Priority,
        /// <summary>
        ///
        /// </summary>
        Ultrafast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveResponsesServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponsesServiceTier value)
        {
            return value switch
            {
                LiveResponsesServiceTier.Auto => "auto",
                LiveResponsesServiceTier.Default => "default",
                LiveResponsesServiceTier.FastTierTempPilot => "fast_tier_temp_pilot",
                LiveResponsesServiceTier.Flex => "flex",
                LiveResponsesServiceTier.Priority => "priority",
                LiveResponsesServiceTier.Ultrafast => "ultrafast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponsesServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => LiveResponsesServiceTier.Auto,
                "default" => LiveResponsesServiceTier.Default,
                "fast_tier_temp_pilot" => LiveResponsesServiceTier.FastTierTempPilot,
                "flex" => LiveResponsesServiceTier.Flex,
                "priority" => LiveResponsesServiceTier.Priority,
                "ultrafast" => LiveResponsesServiceTier.Ultrafast,
                _ => null,
            };
        }
    }
}