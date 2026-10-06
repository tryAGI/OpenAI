
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: apply_patch
    /// </summary>
    public enum LiveApplyPatchToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveApplyPatchToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveApplyPatchToolInputParamType value)
        {
            return value switch
            {
                LiveApplyPatchToolInputParamType.ApplyPatch => "apply_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveApplyPatchToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => LiveApplyPatchToolInputParamType.ApplyPatch,
                _ => null,
            };
        }
    }
}