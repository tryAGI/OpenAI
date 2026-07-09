
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The operation type. Always `update_file`.<br/>
    /// Default Value: update_file
    /// </summary>
    public enum BetaApplyPatchUpdateFileOperationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        UpdateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApplyPatchUpdateFileOperationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchUpdateFileOperationParamType value)
        {
            return value switch
            {
                BetaApplyPatchUpdateFileOperationParamType.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchUpdateFileOperationParamType? ToEnum(string value)
        {
            return value switch
            {
                "update_file" => BetaApplyPatchUpdateFileOperationParamType.UpdateFile,
                _ => null,
            };
        }
    }
}