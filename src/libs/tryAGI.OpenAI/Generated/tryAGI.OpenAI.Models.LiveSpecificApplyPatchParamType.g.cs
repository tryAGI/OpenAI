
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `apply_patch`.<br/>
    /// Default Value: apply_patch
    /// </summary>
    public enum LiveSpecificApplyPatchParamType
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpecificApplyPatchParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpecificApplyPatchParamType value)
        {
            return value switch
            {
                LiveSpecificApplyPatchParamType.ApplyPatch => "apply_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpecificApplyPatchParamType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => LiveSpecificApplyPatchParamType.ApplyPatch,
                _ => null,
            };
        }
    }
}