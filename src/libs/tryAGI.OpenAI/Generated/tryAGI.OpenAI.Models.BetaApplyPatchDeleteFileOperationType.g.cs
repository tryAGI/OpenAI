
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Delete the specified file.<br/>
    /// Default Value: delete_file
    /// </summary>
    public enum BetaApplyPatchDeleteFileOperationType
    {
        /// <summary>
        /// 
        /// </summary>
        DeleteFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApplyPatchDeleteFileOperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchDeleteFileOperationType value)
        {
            return value switch
            {
                BetaApplyPatchDeleteFileOperationType.DeleteFile => "delete_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchDeleteFileOperationType? ToEnum(string value)
        {
            return value switch
            {
                "delete_file" => BetaApplyPatchDeleteFileOperationType.DeleteFile,
                _ => null,
            };
        }
    }
}