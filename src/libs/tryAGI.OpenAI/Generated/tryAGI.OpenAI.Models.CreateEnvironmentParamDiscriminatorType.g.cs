
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateEnvironmentParamDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        OpenaiHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEnvironmentParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnvironmentParamDiscriminatorType value)
        {
            return value switch
            {
                CreateEnvironmentParamDiscriminatorType.OpenaiHosted => "openai_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEnvironmentParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "openai_hosted" => CreateEnvironmentParamDiscriminatorType.OpenaiHosted,
                _ => null,
            };
        }
    }
}