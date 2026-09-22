
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvironmentParamDiscriminatorType
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
    public static class EnvironmentParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentParamDiscriminatorType value)
        {
            return value switch
            {
                EnvironmentParamDiscriminatorType.None => "none",
                EnvironmentParamDiscriminatorType.OpenaiHosted => "openai_hosted",
                EnvironmentParamDiscriminatorType.SelfHosted => "self_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "none" => EnvironmentParamDiscriminatorType.None,
                "openai_hosted" => EnvironmentParamDiscriminatorType.OpenaiHosted,
                "self_hosted" => EnvironmentParamDiscriminatorType.SelfHosted,
                _ => null,
            };
        }
    }
}