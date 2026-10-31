
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputMessageDeveloperVariant2Role
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputMessageDeveloperVariant2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputMessageDeveloperVariant2Role value)
        {
            return value switch
            {
                RealtimeResponseInputMessageDeveloperVariant2Role.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputMessageDeveloperVariant2Role? ToEnum(string value)
        {
            return value switch
            {
                "developer" => RealtimeResponseInputMessageDeveloperVariant2Role.Developer,
                _ => null,
            };
        }
    }
}