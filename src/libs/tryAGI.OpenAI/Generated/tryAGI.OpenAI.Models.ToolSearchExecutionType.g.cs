
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolSearchExecutionType
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Server,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchExecutionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchExecutionType value)
        {
            return value switch
            {
                ToolSearchExecutionType.Client => "client",
                ToolSearchExecutionType.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchExecutionType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ToolSearchExecutionType.Client,
                "server" => ToolSearchExecutionType.Server,
                _ => null,
            };
        }
    }
}