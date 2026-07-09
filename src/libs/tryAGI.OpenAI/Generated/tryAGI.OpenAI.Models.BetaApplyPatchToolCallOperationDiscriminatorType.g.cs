
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaApplyPatchToolCallOperationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CreateFile,
        /// <summary>
        /// 
        /// </summary>
        DeleteFile,
        /// <summary>
        /// 
        /// </summary>
        UpdateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApplyPatchToolCallOperationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchToolCallOperationDiscriminatorType value)
        {
            return value switch
            {
                BetaApplyPatchToolCallOperationDiscriminatorType.CreateFile => "create_file",
                BetaApplyPatchToolCallOperationDiscriminatorType.DeleteFile => "delete_file",
                BetaApplyPatchToolCallOperationDiscriminatorType.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchToolCallOperationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => BetaApplyPatchToolCallOperationDiscriminatorType.CreateFile,
                "delete_file" => BetaApplyPatchToolCallOperationDiscriminatorType.DeleteFile,
                "update_file" => BetaApplyPatchToolCallOperationDiscriminatorType.UpdateFile,
                _ => null,
            };
        }
    }
}