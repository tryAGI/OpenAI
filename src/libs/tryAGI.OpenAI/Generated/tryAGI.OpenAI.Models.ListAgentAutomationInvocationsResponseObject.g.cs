
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `list`.<br/>
    /// Default Value: list
    /// </summary>
    public enum ListAgentAutomationInvocationsResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAgentAutomationInvocationsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentAutomationInvocationsResponseObject value)
        {
            return value switch
            {
                ListAgentAutomationInvocationsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentAutomationInvocationsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListAgentAutomationInvocationsResponseObject.List,
                _ => null,
            };
        }
    }
}