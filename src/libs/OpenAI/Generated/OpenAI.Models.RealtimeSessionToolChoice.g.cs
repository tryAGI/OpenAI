
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// How the model chooses tools.<br/>
    /// Example: auto
    /// </summary>
    public enum RealtimeSessionToolChoice
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
    public static class RealtimeSessionToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionToolChoice value)
        {
            return value switch
            {
                RealtimeSessionToolChoice.Auto => "auto",
                RealtimeSessionToolChoice.None => "none",
                RealtimeSessionToolChoice.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeSessionToolChoice.Auto,
                "none" => RealtimeSessionToolChoice.None,
                "required" => RealtimeSessionToolChoice.Required,
                _ => null,
            };
        }
    }
}