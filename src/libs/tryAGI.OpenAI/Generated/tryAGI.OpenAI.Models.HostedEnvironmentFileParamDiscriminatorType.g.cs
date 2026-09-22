
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedEnvironmentFileParamDiscriminatorType
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
    public static class HostedEnvironmentFileParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedEnvironmentFileParamDiscriminatorType value)
        {
            return value switch
            {
                HostedEnvironmentFileParamDiscriminatorType.FileId => "file_id",
                HostedEnvironmentFileParamDiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedEnvironmentFileParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => HostedEnvironmentFileParamDiscriminatorType.FileId,
                "inline" => HostedEnvironmentFileParamDiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}