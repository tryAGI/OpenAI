
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The current status of a subagent.
    /// </summary>
    public enum SubagentStatusResource
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubagentStatusResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubagentStatusResource value)
        {
            return value switch
            {
                SubagentStatusResource.Active => "active",
                SubagentStatusResource.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubagentStatusResource? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubagentStatusResource.Active,
                "closed" => SubagentStatusResource.Closed,
                _ => null,
            };
        }
    }
}