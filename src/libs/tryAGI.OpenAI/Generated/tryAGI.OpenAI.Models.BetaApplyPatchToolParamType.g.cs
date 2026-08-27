
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the tool. Always `apply_patch`.<br/>
    /// Default Value: apply_patch
    /// </summary>
    public enum BetaApplyPatchToolParamType
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApplyPatchToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchToolParamType value)
        {
            return value switch
            {
                BetaApplyPatchToolParamType.ApplyPatch => "apply_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => BetaApplyPatchToolParamType.ApplyPatch,
                _ => null,
            };
        }
    }
}