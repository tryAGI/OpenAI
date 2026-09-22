
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `file_id`.<br/>
    /// Default Value: file_id
    /// </summary>
    public enum HostedEnvironmentFileParamFileIdType
    {
        /// <summary>
        ///
        /// </summary>
        FileId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedEnvironmentFileParamFileIdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedEnvironmentFileParamFileIdType value)
        {
            return value switch
            {
                HostedEnvironmentFileParamFileIdType.FileId => "file_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedEnvironmentFileParamFileIdType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => HostedEnvironmentFileParamFileIdType.FileId,
                _ => null,
            };
        }
    }
}