
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The operation type. Always `create_file`.<br/>
    /// Default Value: create_file
    /// </summary>
    public enum ApplyPatchCreateFileOperationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        CreateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCreateFileOperationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCreateFileOperationParamType value)
        {
            return value switch
            {
                ApplyPatchCreateFileOperationParamType.CreateFile => "create_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCreateFileOperationParamType? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => ApplyPatchCreateFileOperationParamType.CreateFile,
                _ => null,
            };
        }
    }
}