
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvironmentResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        OpenaiHosted,
        /// <summary>
        ///
        /// </summary>
        SelfHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentResourceDiscriminatorType value)
        {
            return value switch
            {
                EnvironmentResourceDiscriminatorType.None => "none",
                EnvironmentResourceDiscriminatorType.OpenaiHosted => "openai_hosted",
                EnvironmentResourceDiscriminatorType.SelfHosted => "self_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "none" => EnvironmentResourceDiscriminatorType.None,
                "openai_hosted" => EnvironmentResourceDiscriminatorType.OpenaiHosted,
                "self_hosted" => EnvironmentResourceDiscriminatorType.SelfHosted,
                _ => null,
            };
        }
    }
}