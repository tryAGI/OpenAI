
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Create a new file with the provided diff.<br/>
    /// Default Value: create_file
    /// </summary>
    public enum BetaApplyPatchCreateFileOperationType
    {
        /// <summary>
        ///
        /// </summary>
        CreateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApplyPatchCreateFileOperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchCreateFileOperationType value)
        {
            return value switch
            {
                BetaApplyPatchCreateFileOperationType.CreateFile => "create_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchCreateFileOperationType? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => BetaApplyPatchCreateFileOperationType.CreateFile,
                _ => null,
            };
        }
    }
}