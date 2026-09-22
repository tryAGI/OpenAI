
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `command_execution`.<br/>
    /// Default Value: command_execution
    /// </summary>
    public enum CommandExecutionItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        CommandExecution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommandExecutionItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommandExecutionItemResourceType value)
        {
            return value switch
            {
                CommandExecutionItemResourceType.CommandExecution => "command_execution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommandExecutionItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "command_execution" => CommandExecutionItemResourceType.CommandExecution,
                _ => null,
            };
        }
    }
}