
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerAuto,
        /// <summary>
        ///
        /// </summary>
        ContainerReference,
        /// <summary>
        ///
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType value)
        {
            return value switch
            {
                LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType.ContainerAuto => "container_auto",
                LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType.ContainerReference => "container_reference",
                LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_auto" => LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType.ContainerAuto,
                "container_reference" => LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType.ContainerReference,
                "local" => LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType.Local,
                _ => null,
            };
        }
    }
}