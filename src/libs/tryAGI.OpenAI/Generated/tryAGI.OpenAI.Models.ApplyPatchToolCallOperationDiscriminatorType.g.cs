
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchToolCallOperationDiscriminatorType
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
    public static class ApplyPatchToolCallOperationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchToolCallOperationDiscriminatorType value)
        {
            return value switch
            {
                ApplyPatchToolCallOperationDiscriminatorType.CreateFile => "create_file",
                ApplyPatchToolCallOperationDiscriminatorType.DeleteFile => "delete_file",
                ApplyPatchToolCallOperationDiscriminatorType.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchToolCallOperationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => ApplyPatchToolCallOperationDiscriminatorType.CreateFile,
                "delete_file" => ApplyPatchToolCallOperationDiscriminatorType.DeleteFile,
                "update_file" => ApplyPatchToolCallOperationDiscriminatorType.UpdateFile,
                _ => null,
            };
        }
    }
}