
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of error that caused the response to fail, corresponding <br/>
    /// with the `status` field (`completed`, `cancelled`, `incomplete`, <br/>
    /// `failed`).
    /// </summary>
    public enum RealtimeBetaResponseStatusDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaResponseStatusDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseStatusDetailsType value)
        {
            return value switch
            {
                RealtimeBetaResponseStatusDetailsType.Completed => "completed",
                RealtimeBetaResponseStatusDetailsType.Cancelled => "cancelled",
                RealtimeBetaResponseStatusDetailsType.Incomplete => "incomplete",
                RealtimeBetaResponseStatusDetailsType.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseStatusDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeBetaResponseStatusDetailsType.Completed,
                "cancelled" => RealtimeBetaResponseStatusDetailsType.Cancelled,
                "incomplete" => RealtimeBetaResponseStatusDetailsType.Incomplete,
                "failed" => RealtimeBetaResponseStatusDetailsType.Failed,
                _ => null,
            };
        }
    }
}