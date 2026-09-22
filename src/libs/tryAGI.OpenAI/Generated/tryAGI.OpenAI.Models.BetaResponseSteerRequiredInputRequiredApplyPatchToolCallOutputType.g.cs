
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatchCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType value)
        {
            return value switch
            {
                BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType.ApplyPatchCallOutput => "apply_patch_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call_output" => BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType.ApplyPatchCallOutput,
                _ => null,
            };
        }
    }
}