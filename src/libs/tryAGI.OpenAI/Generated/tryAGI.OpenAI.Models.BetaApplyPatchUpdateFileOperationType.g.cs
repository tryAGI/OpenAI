
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Update an existing file with the provided diff.<br/>
    /// Default Value: update_file
    /// </summary>
    public enum BetaApplyPatchUpdateFileOperationType
    {
        /// <summary>
        ///
        /// </summary>
        UpdateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApplyPatchUpdateFileOperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchUpdateFileOperationType value)
        {
            return value switch
            {
                BetaApplyPatchUpdateFileOperationType.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchUpdateFileOperationType? ToEnum(string value)
        {
            return value switch
            {
                "update_file" => BetaApplyPatchUpdateFileOperationType.UpdateFile,
                _ => null,
            };
        }
    }
}