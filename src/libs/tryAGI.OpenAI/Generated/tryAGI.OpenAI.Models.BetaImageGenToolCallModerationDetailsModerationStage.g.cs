
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The stage where moderation blocked the image generation call.
    /// </summary>
    public enum BetaImageGenToolCallModerationDetailsModerationStage
    {
        /// <summary>
        ///
        /// </summary>
        Input,
        /// <summary>
        ///
        /// </summary>
        Output,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageGenToolCallModerationDetailsModerationStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolCallModerationDetailsModerationStage value)
        {
            return value switch
            {
                BetaImageGenToolCallModerationDetailsModerationStage.Input => "input",
                BetaImageGenToolCallModerationDetailsModerationStage.Output => "output",
                BetaImageGenToolCallModerationDetailsModerationStage.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolCallModerationDetailsModerationStage? ToEnum(string value)
        {
            return value switch
            {
                "input" => BetaImageGenToolCallModerationDetailsModerationStage.Input,
                "output" => BetaImageGenToolCallModerationDetailsModerationStage.Output,
                "unknown" => BetaImageGenToolCallModerationDetailsModerationStage.Unknown,
                _ => null,
            };
        }
    }
}