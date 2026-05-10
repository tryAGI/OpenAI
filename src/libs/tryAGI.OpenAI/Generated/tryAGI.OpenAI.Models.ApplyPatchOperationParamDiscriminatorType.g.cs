
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchOperationParamDiscriminatorType
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
    public static class ApplyPatchOperationParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchOperationParamDiscriminatorType value)
        {
            return value switch
            {
                ApplyPatchOperationParamDiscriminatorType.CreateFile => "create_file",
                ApplyPatchOperationParamDiscriminatorType.DeleteFile => "delete_file",
                ApplyPatchOperationParamDiscriminatorType.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchOperationParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => ApplyPatchOperationParamDiscriminatorType.CreateFile,
                "delete_file" => ApplyPatchOperationParamDiscriminatorType.DeleteFile,
                "update_file" => ApplyPatchOperationParamDiscriminatorType.UpdateFile,
                _ => null,
            };
        }
    }
}