
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `apply_patch_call`.<br/>
    /// Default Value: apply_patch_call
    /// </summary>
    public enum BetaApplyPatchToolCallItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApplyPatchToolCallItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchToolCallItemParamType value)
        {
            return value switch
            {
                BetaApplyPatchToolCallItemParamType.ApplyPatchCall => "apply_patch_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchToolCallItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => BetaApplyPatchToolCallItemParamType.ApplyPatchCall,
                _ => null,
            };
        }
    }
}