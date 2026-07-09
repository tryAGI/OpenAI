
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType
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
    public static class BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType.ContainerAuto => "container_auto",
                BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType.ContainerReference => "container_reference",
                BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_auto" => BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType.ContainerAuto,
                "container_reference" => BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType.ContainerReference,
                "local" => BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType.Local,
                _ => null,
            };
        }
    }
}