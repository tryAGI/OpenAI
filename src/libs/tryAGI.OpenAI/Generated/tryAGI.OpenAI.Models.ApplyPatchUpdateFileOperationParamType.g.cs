
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The operation type. Always `update_file`.<br/>
    /// Default Value: update_file
    /// </summary>
    public enum ApplyPatchUpdateFileOperationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        UpdateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchUpdateFileOperationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchUpdateFileOperationParamType value)
        {
            return value switch
            {
                ApplyPatchUpdateFileOperationParamType.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchUpdateFileOperationParamType? ToEnum(string value)
        {
            return value switch
            {
                "update_file" => ApplyPatchUpdateFileOperationParamType.UpdateFile,
                _ => null,
            };
        }
    }
}