
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `openai_hosted`.<br/>
    /// Default Value: openai_hosted
    /// </summary>
    public enum AutomationEnvironmentResourceOpenaiHostedType
    {
        /// <summary>
        ///
        /// </summary>
        OpenaiHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationEnvironmentResourceOpenaiHostedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationEnvironmentResourceOpenaiHostedType value)
        {
            return value switch
            {
                AutomationEnvironmentResourceOpenaiHostedType.OpenaiHosted => "openai_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationEnvironmentResourceOpenaiHostedType? ToEnum(string value)
        {
            return value switch
            {
                "openai_hosted" => AutomationEnvironmentResourceOpenaiHostedType.OpenaiHosted,
                _ => null,
            };
        }
    }
}