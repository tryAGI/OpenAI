
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `automations`.<br/>
    /// Default Value: automations
    /// </summary>
    public enum AgentToolConfigParamAutomationsType
    {
        /// <summary>
        ///
        /// </summary>
        Automations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolConfigParamAutomationsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolConfigParamAutomationsType value)
        {
            return value switch
            {
                AgentToolConfigParamAutomationsType.Automations => "automations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolConfigParamAutomationsType? ToEnum(string value)
        {
            return value switch
            {
                "automations" => AgentToolConfigParamAutomationsType.Automations,
                _ => null,
            };
        }
    }
}