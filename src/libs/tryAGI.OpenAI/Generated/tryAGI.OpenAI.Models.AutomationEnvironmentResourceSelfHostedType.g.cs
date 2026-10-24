
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `self_hosted`.<br/>
    /// Default Value: self_hosted
    /// </summary>
    public enum AutomationEnvironmentResourceSelfHostedType
    {
        /// <summary>
        ///
        /// </summary>
        SelfHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationEnvironmentResourceSelfHostedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationEnvironmentResourceSelfHostedType value)
        {
            return value switch
            {
                AutomationEnvironmentResourceSelfHostedType.SelfHosted => "self_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationEnvironmentResourceSelfHostedType? ToEnum(string value)
        {
            return value switch
            {
                "self_hosted" => AutomationEnvironmentResourceSelfHostedType.SelfHosted,
                _ => null,
            };
        }
    }
}