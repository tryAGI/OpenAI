
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveMCPRequireApprovalApiEnum
    {
        /// <summary>
        ///
        /// </summary>
        Always,
        /// <summary>
        ///
        /// </summary>
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveMCPRequireApprovalApiEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveMCPRequireApprovalApiEnum value)
        {
            return value switch
            {
                LiveMCPRequireApprovalApiEnum.Always => "always",
                LiveMCPRequireApprovalApiEnum.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveMCPRequireApprovalApiEnum? ToEnum(string value)
        {
            return value switch
            {
                "always" => LiveMCPRequireApprovalApiEnum.Always,
                "never" => LiveMCPRequireApprovalApiEnum.Never,
                _ => null,
            };
        }
    }
}