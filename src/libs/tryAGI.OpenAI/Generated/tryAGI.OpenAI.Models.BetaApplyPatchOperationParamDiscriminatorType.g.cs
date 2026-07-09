
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaApplyPatchOperationParamDiscriminatorType
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
    public static class BetaApplyPatchOperationParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchOperationParamDiscriminatorType value)
        {
            return value switch
            {
                BetaApplyPatchOperationParamDiscriminatorType.CreateFile => "create_file",
                BetaApplyPatchOperationParamDiscriminatorType.DeleteFile => "delete_file",
                BetaApplyPatchOperationParamDiscriminatorType.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchOperationParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => BetaApplyPatchOperationParamDiscriminatorType.CreateFile,
                "delete_file" => BetaApplyPatchOperationParamDiscriminatorType.DeleteFile,
                "update_file" => BetaApplyPatchOperationParamDiscriminatorType.UpdateFile,
                _ => null,
            };
        }
    }
}