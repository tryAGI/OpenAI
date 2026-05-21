
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionShellToolParamEnvironmentVariant1DiscriminatorType
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
    public static class FunctionShellToolParamEnvironmentVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellToolParamEnvironmentVariant1DiscriminatorType value)
        {
            return value switch
            {
                FunctionShellToolParamEnvironmentVariant1DiscriminatorType.ContainerAuto => "container_auto",
                FunctionShellToolParamEnvironmentVariant1DiscriminatorType.ContainerReference => "container_reference",
                FunctionShellToolParamEnvironmentVariant1DiscriminatorType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellToolParamEnvironmentVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_auto" => FunctionShellToolParamEnvironmentVariant1DiscriminatorType.ContainerAuto,
                "container_reference" => FunctionShellToolParamEnvironmentVariant1DiscriminatorType.ContainerReference,
                "local" => FunctionShellToolParamEnvironmentVariant1DiscriminatorType.Local,
                _ => null,
            };
        }
    }
}