
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Update an existing file with the provided diff.<br/>
    /// Default Value: update_file
    /// </summary>
    public enum ApplyPatchUpdateFileOperationType
    {
        /// <summary>
        /// 
        /// </summary>
        UpdateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchUpdateFileOperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchUpdateFileOperationType value)
        {
            return value switch
            {
                ApplyPatchUpdateFileOperationType.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchUpdateFileOperationType? ToEnum(string value)
        {
            return value switch
            {
                "update_file" => ApplyPatchUpdateFileOperationType.UpdateFile,
                _ => null,
            };
        }
    }
}