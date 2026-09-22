
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedEnvironmentFileResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        FileId,
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedEnvironmentFileResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedEnvironmentFileResourceDiscriminatorType value)
        {
            return value switch
            {
                HostedEnvironmentFileResourceDiscriminatorType.FileId => "file_id",
                HostedEnvironmentFileResourceDiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedEnvironmentFileResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => HostedEnvironmentFileResourceDiscriminatorType.FileId,
                "inline" => HostedEnvironmentFileResourceDiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}