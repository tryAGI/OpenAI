
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The operation type. Always `delete_file`.<br/>
    /// Default Value: delete_file
    /// </summary>
    public enum ApplyPatchDeleteFileOperationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        DeleteFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchDeleteFileOperationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchDeleteFileOperationParamType value)
        {
            return value switch
            {
                ApplyPatchDeleteFileOperationParamType.DeleteFile => "delete_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchDeleteFileOperationParamType? ToEnum(string value)
        {
            return value switch
            {
                "delete_file" => ApplyPatchDeleteFileOperationParamType.DeleteFile,
                _ => null,
            };
        }
    }
}