
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `file_id`.<br/>
    /// Default Value: file_id
    /// </summary>
    public enum HostedEnvironmentFileResourceFileIdType
    {
        /// <summary>
        ///
        /// </summary>
        FileId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedEnvironmentFileResourceFileIdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedEnvironmentFileResourceFileIdType value)
        {
            return value switch
            {
                HostedEnvironmentFileResourceFileIdType.FileId => "file_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedEnvironmentFileResourceFileIdType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => HostedEnvironmentFileResourceFileIdType.FileId,
                _ => null,
            };
        }
    }
}