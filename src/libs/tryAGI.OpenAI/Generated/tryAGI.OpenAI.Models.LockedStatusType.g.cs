
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Status discriminator that is always `locked`.<br/>
    /// Default Value: locked
    /// </summary>
    public enum LockedStatusType
    {
        /// <summary>
        /// 
        /// </summary>
        Locked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LockedStatusTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LockedStatusType value)
        {
            return value switch
            {
                LockedStatusType.Locked => "locked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LockedStatusType? ToEnum(string value)
        {
            return value switch
            {
                "locked" => LockedStatusType.Locked,
                _ => null,
            };
        }
    }
}