
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `list`.<br/>
    /// Default Value: list
    /// </summary>
    public enum ListAgentAutomationsResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAgentAutomationsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentAutomationsResponseObject value)
        {
            return value switch
            {
                ListAgentAutomationsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentAutomationsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListAgentAutomationsResponseObject.List,
                _ => null,
            };
        }
    }
}