
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeResponseCreateResponseToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseCreateResponseToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateResponseToolChoice value)
        {
            return value switch
            {
                RealtimeResponseCreateResponseToolChoice.Auto => "auto",
                RealtimeResponseCreateResponseToolChoice.None => "none",
                RealtimeResponseCreateResponseToolChoice.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateResponseToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeResponseCreateResponseToolChoice.Auto,
                "none" => RealtimeResponseCreateResponseToolChoice.None,
                "required" => RealtimeResponseCreateResponseToolChoice.Required,
                _ => null,
            };
        }
    }
}