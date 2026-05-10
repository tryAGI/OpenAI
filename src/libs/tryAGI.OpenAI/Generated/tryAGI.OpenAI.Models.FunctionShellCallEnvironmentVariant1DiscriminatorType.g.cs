
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionShellCallEnvironmentVariant1DiscriminatorType
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
    public static class FunctionShellCallEnvironmentVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallEnvironmentVariant1DiscriminatorType value)
        {
            return value switch
            {
                FunctionShellCallEnvironmentVariant1DiscriminatorType.ContainerReference => "container_reference",
                FunctionShellCallEnvironmentVariant1DiscriminatorType.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallEnvironmentVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_reference" => FunctionShellCallEnvironmentVariant1DiscriminatorType.ContainerReference,
                "local" => FunctionShellCallEnvironmentVariant1DiscriminatorType.Local,
                _ => null,
            };
        }
    }
}