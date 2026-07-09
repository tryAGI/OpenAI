
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType
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
    public static class BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType.ContainerReference => "container_reference",
                BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_reference" => BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType.ContainerReference,
                "local" => BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType.Local,
                _ => null,
            };
        }
    }
}