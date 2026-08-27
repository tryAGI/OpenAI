
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFunctionShellCallEnvironmentVariant1DiscriminatorType
    {
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
    public static class BetaFunctionShellCallEnvironmentVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallEnvironmentVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaFunctionShellCallEnvironmentVariant1DiscriminatorType.ContainerReference => "container_reference",
                BetaFunctionShellCallEnvironmentVariant1DiscriminatorType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallEnvironmentVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_reference" => BetaFunctionShellCallEnvironmentVariant1DiscriminatorType.ContainerReference,
                "local" => BetaFunctionShellCallEnvironmentVariant1DiscriminatorType.Local,
                _ => null,
            };
        }
    }
}