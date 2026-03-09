
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.client_tool_call`.<br/>
    /// Default Value: chatkit.client_tool_call
    /// </summary>
    public enum ClientToolCallItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitClientToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientToolCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolCallItemType value)
        {
            return value switch
            {
                ClientToolCallItemType.ChatkitClientToolCall => "chatkit.client_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.client_tool_call" => ClientToolCallItemType.ChatkitClientToolCall,
                _ => null,
            };
        }
    }
}