
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatchCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType value)
        {
            return value switch
            {
                ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType.ApplyPatchCallOutput => "apply_patch_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call_output" => ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType.ApplyPatchCallOutput,
                _ => null,
            };
        }
    }
}