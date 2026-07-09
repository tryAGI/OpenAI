
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaModelIdsResponsesEnum
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview,
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview20250311,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Codex,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Pro,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Pro20251006,
        /// <summary>
        /// 
        /// </summary>
        Gpt51CodexMax,
        /// <summary>
        /// 
        /// </summary>
        O1Pro,
        /// <summary>
        /// 
        /// </summary>
        O1Pro20250319,
        /// <summary>
        /// 
        /// </summary>
        O3DeepResearch,
        /// <summary>
        /// 
        /// </summary>
        O3DeepResearch20250626,
        /// <summary>
        /// 
        /// </summary>
        O3Pro,
        /// <summary>
        /// 
        /// </summary>
        O3Pro20250610,
        /// <summary>
        /// 
        /// </summary>
        O4MiniDeepResearch,
        /// <summary>
        /// 
        /// </summary>
        O4MiniDeepResearch20250626,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaModelIdsResponsesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaModelIdsResponsesEnum value)
        {
            return value switch
            {
                BetaModelIdsResponsesEnum.ComputerUsePreview => "computer-use-preview",
                BetaModelIdsResponsesEnum.ComputerUsePreview20250311 => "computer-use-preview-2025-03-11",
                BetaModelIdsResponsesEnum.Gpt5Codex => "gpt-5-codex",
                BetaModelIdsResponsesEnum.Gpt5Pro => "gpt-5-pro",
                BetaModelIdsResponsesEnum.Gpt5Pro20251006 => "gpt-5-pro-2025-10-06",
                BetaModelIdsResponsesEnum.Gpt51CodexMax => "gpt-5.1-codex-max",
                BetaModelIdsResponsesEnum.O1Pro => "o1-pro",
                BetaModelIdsResponsesEnum.O1Pro20250319 => "o1-pro-2025-03-19",
                BetaModelIdsResponsesEnum.O3DeepResearch => "o3-deep-research",
                BetaModelIdsResponsesEnum.O3DeepResearch20250626 => "o3-deep-research-2025-06-26",
                BetaModelIdsResponsesEnum.O3Pro => "o3-pro",
                BetaModelIdsResponsesEnum.O3Pro20250610 => "o3-pro-2025-06-10",
                BetaModelIdsResponsesEnum.O4MiniDeepResearch => "o4-mini-deep-research",
                BetaModelIdsResponsesEnum.O4MiniDeepResearch20250626 => "o4-mini-deep-research-2025-06-26",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaModelIdsResponsesEnum? ToEnum(string value)
        {
            return value switch
            {
                "computer-use-preview" => BetaModelIdsResponsesEnum.ComputerUsePreview,
                "computer-use-preview-2025-03-11" => BetaModelIdsResponsesEnum.ComputerUsePreview20250311,
                "gpt-5-codex" => BetaModelIdsResponsesEnum.Gpt5Codex,
                "gpt-5-pro" => BetaModelIdsResponsesEnum.Gpt5Pro,
                "gpt-5-pro-2025-10-06" => BetaModelIdsResponsesEnum.Gpt5Pro20251006,
                "gpt-5.1-codex-max" => BetaModelIdsResponsesEnum.Gpt51CodexMax,
                "o1-pro" => BetaModelIdsResponsesEnum.O1Pro,
                "o1-pro-2025-03-19" => BetaModelIdsResponsesEnum.O1Pro20250319,
                "o3-deep-research" => BetaModelIdsResponsesEnum.O3DeepResearch,
                "o3-deep-research-2025-06-26" => BetaModelIdsResponsesEnum.O3DeepResearch20250626,
                "o3-pro" => BetaModelIdsResponsesEnum.O3Pro,
                "o3-pro-2025-06-10" => BetaModelIdsResponsesEnum.O3Pro20250610,
                "o4-mini-deep-research" => BetaModelIdsResponsesEnum.O4MiniDeepResearch,
                "o4-mini-deep-research-2025-06-26" => BetaModelIdsResponsesEnum.O4MiniDeepResearch20250626,
                _ => null,
            };
        }
    }
}