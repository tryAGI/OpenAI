
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType
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
    public static class FunctionShellCallItemParamEnvironmentVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType value)
        {
            return value switch
            {
                FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType.ContainerReference => "container_reference",
                FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_reference" => FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType.ContainerReference,
                "local" => FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType.Local,
                _ => null,
            };
        }
    }
}