
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `automation`.<br/>
    /// Default Value: automation
    /// </summary>
    public enum AutomationInvocationSourceResourceAutomationType
    {
        /// <summary>
        ///
        /// </summary>
        Automation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationInvocationSourceResourceAutomationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationInvocationSourceResourceAutomationType value)
        {
            return value switch
            {
                AutomationInvocationSourceResourceAutomationType.Automation => "automation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationInvocationSourceResourceAutomationType? ToEnum(string value)
        {
            return value switch
            {
                "automation" => AutomationInvocationSourceResourceAutomationType.Automation,
                _ => null,
            };
        }
    }
}