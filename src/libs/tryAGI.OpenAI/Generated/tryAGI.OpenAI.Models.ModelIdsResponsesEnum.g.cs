
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelIdsResponsesEnum
    {
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
        O3Pro,
        /// <summary>
        /// 
        /// </summary>
        O3Pro20250610,
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
        O4MiniDeepResearch,
        /// <summary>
        /// 
        /// </summary>
        O4MiniDeepResearch20250626,
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview,
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview20250311,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelIdsResponsesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelIdsResponsesEnum value)
        {
            return value switch
            {
                ModelIdsResponsesEnum.O1Pro => "o1-pro",
                ModelIdsResponsesEnum.O1Pro20250319 => "o1-pro-2025-03-19",
                ModelIdsResponsesEnum.O3Pro => "o3-pro",
                ModelIdsResponsesEnum.O3Pro20250610 => "o3-pro-2025-06-10",
                ModelIdsResponsesEnum.O3DeepResearch => "o3-deep-research",
                ModelIdsResponsesEnum.O3DeepResearch20250626 => "o3-deep-research-2025-06-26",
                ModelIdsResponsesEnum.O4MiniDeepResearch => "o4-mini-deep-research",
                ModelIdsResponsesEnum.O4MiniDeepResearch20250626 => "o4-mini-deep-research-2025-06-26",
                ModelIdsResponsesEnum.ComputerUsePreview => "computer-use-preview",
                ModelIdsResponsesEnum.ComputerUsePreview20250311 => "computer-use-preview-2025-03-11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelIdsResponsesEnum? ToEnum(string value)
        {
            return value switch
            {
                "o1-pro" => ModelIdsResponsesEnum.O1Pro,
                "o1-pro-2025-03-19" => ModelIdsResponsesEnum.O1Pro20250319,
                "o3-pro" => ModelIdsResponsesEnum.O3Pro,
                "o3-pro-2025-06-10" => ModelIdsResponsesEnum.O3Pro20250610,
                "o3-deep-research" => ModelIdsResponsesEnum.O3DeepResearch,
                "o3-deep-research-2025-06-26" => ModelIdsResponsesEnum.O3DeepResearch20250626,
                "o4-mini-deep-research" => ModelIdsResponsesEnum.O4MiniDeepResearch,
                "o4-mini-deep-research-2025-06-26" => ModelIdsResponsesEnum.O4MiniDeepResearch20250626,
                "computer-use-preview" => ModelIdsResponsesEnum.ComputerUsePreview,
                "computer-use-preview-2025-03-11" => ModelIdsResponsesEnum.ComputerUsePreview20250311,
                _ => null,
            };
        }
    }
}