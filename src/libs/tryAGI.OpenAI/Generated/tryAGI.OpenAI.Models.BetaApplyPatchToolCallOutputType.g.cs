
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `apply_patch_call_output`.<br/>
    /// Default Value: apply_patch_call_output
    /// </summary>
    public enum BetaApplyPatchToolCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApplyPatchToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchToolCallOutputType value)
        {
            return value switch
            {
                BetaApplyPatchToolCallOutputType.ApplyPatchCallOutput => "apply_patch_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call_output" => BetaApplyPatchToolCallOutputType.ApplyPatchCallOutput,
                _ => null,
            };
        }
    }
}