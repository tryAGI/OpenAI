
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatSessionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatSessionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSessionStatus value)
        {
            return value switch
            {
                ChatSessionStatus.Active => "active",
                ChatSessionStatus.Expired => "expired",
                ChatSessionStatus.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSessionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ChatSessionStatus.Active,
                "expired" => ChatSessionStatus.Expired,
                "cancelled" => ChatSessionStatus.Cancelled,
                _ => null,
            };
        }
    }
}