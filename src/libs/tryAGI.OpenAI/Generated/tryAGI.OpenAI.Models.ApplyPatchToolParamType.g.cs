
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the tool. Always `apply_patch`.<br/>
    /// Default Value: apply_patch
    /// </summary>
    public enum ApplyPatchToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchToolParamType value)
        {
            return value switch
            {
                ApplyPatchToolParamType.ApplyPatch => "apply_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => ApplyPatchToolParamType.ApplyPatch,
                _ => null,
            };
        }
    }
}