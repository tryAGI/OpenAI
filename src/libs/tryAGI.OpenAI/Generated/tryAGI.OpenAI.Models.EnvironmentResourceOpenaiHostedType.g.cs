
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `openai_hosted`.<br/>
    /// Default Value: openai_hosted
    /// </summary>
    public enum EnvironmentResourceOpenaiHostedType
    {
        /// <summary>
        ///
        /// </summary>
        OpenaiHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentResourceOpenaiHostedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentResourceOpenaiHostedType value)
        {
            return value switch
            {
                EnvironmentResourceOpenaiHostedType.OpenaiHosted => "openai_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentResourceOpenaiHostedType? ToEnum(string value)
        {
            return value switch
            {
                "openai_hosted" => EnvironmentResourceOpenaiHostedType.OpenaiHosted,
                _ => null,
            };
        }
    }
}