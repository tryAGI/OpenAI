
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the computer use tool. Always `computer_use_preview`.<br/>
    /// Default Value: computer_use_preview
    /// </summary>
    public enum BetaComputerUsePreviewToolType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerUsePreviewToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerUsePreviewToolType value)
        {
            return value switch
            {
                BetaComputerUsePreviewToolType.ComputerUsePreview => "computer_use_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerUsePreviewToolType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_preview" => BetaComputerUsePreviewToolType.ComputerUsePreview,
                _ => null,
            };
        }
    }
}