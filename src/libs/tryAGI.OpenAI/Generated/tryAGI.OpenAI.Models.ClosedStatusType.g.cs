
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Status discriminator that is always `closed`.<br/>
    /// Default Value: closed
    /// </summary>
    public enum ClosedStatusType
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClosedStatusTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClosedStatusType value)
        {
            return value switch
            {
                ClosedStatusType.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClosedStatusType? ToEnum(string value)
        {
            return value switch
            {
                "closed" => ClosedStatusType.Closed,
                _ => null,
            };
        }
    }
}