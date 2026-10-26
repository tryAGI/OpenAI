
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AutomationEnvironmentResourceDiscriminatorType
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
    public static class AutomationEnvironmentResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationEnvironmentResourceDiscriminatorType value)
        {
            return value switch
            {
                AutomationEnvironmentResourceDiscriminatorType.None => "none",
                AutomationEnvironmentResourceDiscriminatorType.OpenaiHosted => "openai_hosted",
                AutomationEnvironmentResourceDiscriminatorType.SelfHosted => "self_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationEnvironmentResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "none" => AutomationEnvironmentResourceDiscriminatorType.None,
                "openai_hosted" => AutomationEnvironmentResourceDiscriminatorType.OpenaiHosted,
                "self_hosted" => AutomationEnvironmentResourceDiscriminatorType.SelfHosted,
                _ => null,
            };
        }
    }
}