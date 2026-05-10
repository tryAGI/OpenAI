
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThreadResourceStatusDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Locked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadResourceStatusDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadResourceStatusDiscriminatorType value)
        {
            return value switch
            {
                ThreadResourceStatusDiscriminatorType.Active => "active",
                ThreadResourceStatusDiscriminatorType.Closed => "closed",
                ThreadResourceStatusDiscriminatorType.Locked => "locked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadResourceStatusDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "active" => ThreadResourceStatusDiscriminatorType.Active,
                "closed" => ThreadResourceStatusDiscriminatorType.Closed,
                "locked" => ThreadResourceStatusDiscriminatorType.Locked,
                _ => null,
            };
        }
    }
}