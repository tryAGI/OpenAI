
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `openai_hosted`.<br/>
    /// Default Value: openai_hosted
    /// </summary>
    public enum CreateEnvironmentParamOpenaiHostedType
    {
        /// <summary>
        ///
        /// </summary>
        OpenaiHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEnvironmentParamOpenaiHostedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnvironmentParamOpenaiHostedType value)
        {
            return value switch
            {
                CreateEnvironmentParamOpenaiHostedType.OpenaiHosted => "openai_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEnvironmentParamOpenaiHostedType? ToEnum(string value)
        {
            return value switch
            {
                "openai_hosted" => CreateEnvironmentParamOpenaiHostedType.OpenaiHosted,
                _ => null,
            };
        }
    }
}